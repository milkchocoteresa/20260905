using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 回路をグラフで整理する。
/// イベントキューを持ち、スケジューラーとしてチップの効果の発動の管理をする。
/// </summary>
public class ChipGraph
{
    public ChipGraph(Board board)
    {
        _board = board;

        _triggerTimingHubs = new Dictionary<GameEnums.Timing, TimingNode>();
        foreach (GameEnums.Timing t in System.Enum.GetValues(typeof(GameEnums.Timing)))
        {
            if (t == GameEnums.Timing.None || t == GameEnums.Timing.Passive || t == GameEnums.Timing.ChipActionTrigger)
            {
                continue;
            }
            _triggerTimingHubs.Add(t, new TimingNode(new List<ChipNode>()));
        }

        _referenceTimingHubs = new Dictionary<GameEnums.Timing, TimingNode>();
        foreach (GameEnums.Timing t in System.Enum.GetValues(typeof(GameEnums.Timing)))
        {
            if (t == GameEnums.Timing.None || t == GameEnums.Timing.Passive || t == GameEnums.Timing.ChipActionTrigger)
            {
                continue;
            }
            _referenceTimingHubs.Add(t, new TimingNode(new List<ChipNode>()));
        }

        _normalReferenceHubs = new Dictionary<GameEnums.Reference, ReferenceNode>();
        foreach (GameEnums.Reference r in System.Enum.GetValues(typeof(GameEnums.Reference)))
        {
            if (r == GameEnums.Reference.None || r == GameEnums.Reference.Chip || r == GameEnums.Reference.Resource)
            {
                continue;
            }
            _normalReferenceHubs.Add(r, new ReferenceNode(new List<ChipNode>()));
        }

        _resourceReferenceHubs = new Dictionary<GameEnums.Resource, ReferenceNode>();
        foreach (GameEnums.Resource r in System.Enum.GetValues(typeof(GameEnums.Resource)))
        {
            _resourceReferenceHubs.Add(r, new ReferenceNode(new List<ChipNode>()));
        }
    }

    private readonly Board _board;
    private abstract class Node { }

    private class ChipNode : Node
    {
        public Chip Chip { get; }
        public List<Node> ReadTriggerTiming { get; } = new();
        public List<ChipNode> TriggerTimingSubscribers { get; } = new();

        public List<Node> ReadReferenceTiming { get; } = new();
        public List<ChipNode> ReferenceTimingSubscribers { get; } = new();

        public List<Node> ReadReference { get; } = new();
        public List<ChipNode> ReferenceSubscribers { get; } = new();

        public ChipNode(Chip chip)
        {
            Chip = chip;
        }
    }

    private class TimingNode : Node
    {
        public List<ChipNode> Subscribers { get; }

        public TimingNode(List<ChipNode> s)
        {
            Subscribers = s;
        }
    }

    private class ReferenceNode : Node
    {
        public List<ChipNode> Subscribers { get; }

        public ReferenceNode(List<ChipNode> s)
        {
            Subscribers = s;
        }
    }

    private readonly Dictionary<GameEnums.Timing, TimingNode> _triggerTimingHubs;            // チップの効果発動のトリガーとなるタイミングのハブ 
    private readonly Dictionary<GameEnums.Timing, TimingNode> _referenceTimingHubs;          // チップの効果発動時の参照に使うタイミングのハブ
    private readonly Dictionary<GameEnums.Reference, ReferenceNode> _normalReferenceHubs;    // リソース以外の参照のハブ
    private readonly Dictionary<GameEnums.Resource, ReferenceNode> _resourceReferenceHubs;   // リソース参照ハブ

    private Dictionary<Chip, ChipNode> _chipToNode = new Dictionary<Chip, ChipNode>();

    /// <summary>
    /// Boardが更新されたときのみ走るため、Boardからのみ呼ばれる。
    /// </summary>
    public void Rebuild(Dictionary<Vector2Int, Chip> chips)
    {
        // _chipToNodeのChipを削除
        _chipToNode.Clear();

        // HubのFromを全て削除
        foreach (var hub in _triggerTimingHubs.Values)
        {
            hub.Subscribers.Clear();
        }
        foreach (var hub in _referenceTimingHubs.Values)
        {
            hub.Subscribers.Clear();
        }
        foreach (var hub in _normalReferenceHubs.Values)
        {
            hub.Subscribers.Clear();
        }
        foreach (var hub in _resourceReferenceHubs.Values)
        {
            hub.Subscribers.Clear();
        }

        //全てのチップのNodeを作る
        foreach (Chip chip in chips.Values)
        {
            _chipToNode.Add(chip, new ChipNode(chip));
        }

        // 周囲のチップを見て無効なチップをUnavailableにする
        foreach (var chip in _chipToNode.Keys) // ボード上のチップについて1つずつ操作
        {
            var con = chip.Condition; // チップの条件
            if (con is ChipSettingConditionChip conc) // 条件がある場合
            {
                List<Chip> chiplist = _board.GetChipFromPos(conc.Positions); // 条件となる範囲に実際に存在するチップのList
                var ctan = new Dictionary<ChipSettingSO, int>(conc.ChipTypesAndNums); // 必要なチップの種類とその個数
                foreach (var c in chiplist) // List内のチップと条件のチップが一致している場合カウントを減らして、0になったらRemove
                {
                    if (ctan.TryGetValue(c.Setting, out int count))
                    {
                        if (count > 0)
                        {
                            ctan[c.Setting] = count - 1;
                        }
                        else
                        {
                            ctan.Remove(c.Setting);
                        }
                    }
                }

                if (ctan.Count > 0) // 最終的に条件の中身が全て消えていれば条件を満たしている
                {
                    chip.SetAvailability(GameEnums.Availability.Unavailable);
                }
                else
                {
                    chip.SetAvailability(GameEnums.Availability.Available);
                }
            }
            else // 条件がない場合
            {
                chip.SetAvailability(GameEnums.Availability.Available);
            }
        }

        // 有効なチップのエッジをつなぐ
        foreach (KeyValuePair<Chip, ChipNode> kvp in _chipToNode)
        {
            ChipSettingRule rule = kvp.Key.Rule;

            // TriggerTimingをつなぐ
            ChipSettingTiming tcst = rule.TriggerTiming;
            if (tcst is ChipSettingTimingCAT catTTiming)
            {
                foreach (var chip in _board.GetChipFromPos(catTTiming.Positions))
                {
                    _chipToNode.TryGetValue(chip, out ChipNode chipNode);
                    kvp.Value.ReadTriggerTiming.Add(chipNode);
                    chipNode.TriggerTimingSubscribers.Add(kvp.Value);
                }
            }
            else if (tcst.Timing == GameEnums.Timing.None || tcst.Timing == GameEnums.Timing.Passive) { }
            else
            {
                _triggerTimingHubs.TryGetValue(rule.TriggerTiming.Timing, out TimingNode ttNode);
                kvp.Value.ReadTriggerTiming.Add(ttNode);
                ttNode.Subscribers.Add(kvp.Value);
            }

            // ReferenceTimingをつなぐ
            foreach (ChipSettingTiming rcst in rule.ReferenceTimings)
            {
                if (rcst is ChipSettingTimingCAT catRTiming)
                {
                    foreach (var chip in _board.GetChipFromPos(catRTiming.Positions))
                    {
                        _chipToNode.TryGetValue(chip, out ChipNode chipNode);
                        kvp.Value.ReadReferenceTiming.Add(chipNode);
                        chipNode.ReferenceTimingSubscribers.Add(kvp.Value);
                    }
                }
                else if (rcst.Timing == GameEnums.Timing.None || rcst.Timing == GameEnums.Timing.Passive) { }
                else
                {
                    _referenceTimingHubs.TryGetValue(rcst.Timing, out TimingNode rtNode);
                    kvp.Value.ReadReferenceTiming.Add(rtNode);
                    rtNode.Subscribers.Add(kvp.Value);
                }
            }

            // Referenceをつなぐ
            foreach (ChipSettingReference rcsr in rule.References)
            {
                if (rcsr is ChipSettingReferenceResource rr)
                {
                    _resourceReferenceHubs.TryGetValue(rr.Resource, out ReferenceNode refNode);
                    kvp.Value.ReadReference.Add(refNode);
                    refNode.Subscribers.Add(kvp.Value);
                }
                else
                {
                    _normalReferenceHubs.TryGetValue(rcsr.Reference, out ReferenceNode refNode);
                    kvp.Value.ReadReference.Add(refNode);
                    refNode.Subscribers.Add(kvp.Value);
                }
            }
        }
    }

    /// <summary>
    /// トリガーに応じて回路を走らせるメソッド。回路のトリガーの入り口となるイベントに登録しておく必要がある。
    /// </summary>
    private void TriggerCircuit(TriggerContext context)
    {
        // 参照用タイミングに先に通知
        _referenceTimingHubs.TryGetValue(context.Timing, out TimingNode rtNode);
        foreach (ChipNode cNode in rtNode.Subscribers)
        {
            cNode.Chip.ReferenceEventReceive(context);
        }

        // トリガータイミングで効果の発動Listを作成
        _triggerTimingHubs.TryGetValue(context.Timing, out TimingNode ttNode);
    }
}
