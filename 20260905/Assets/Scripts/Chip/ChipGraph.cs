using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 回路をグラフで整理する。
/// イベントキューを持ち、スケジューラーとしてチップの効果の発動の管理をする。
/// </summary>
public class ChipGraph
{
    private Board _board;
    private abstract class Node { }

    private class ChipNode : Node
    {
        public Chip Chip { get; }
        public List<Node> TimingTo { get; } = new();
        public List<Node> TimingFrom { get; } = new();

        public List<Node> ReferenceTo { get; } = new();
        public List<Node> ReferenceFrom { get; } = new();

        public List<Node> TargetTo { get; } = new();
        public List<Node> TargetFrom { get; } = new();

        public ChipNode(Chip chip)
        {
            Chip = chip;
        }
    }

    private class TimingNode : Node
    {
        public GameEnums.Timing Timing;

        public List<ChipNode> From { get; }

        public TimingNode(GameEnums.Timing timing, List<ChipNode> from)
        {
            Timing = timing;
            From = from;
        }
    }

    private class ReferenceNode : Node
    {
        public GameEnums.Reference Reference;

        public List<ChipNode> From { get; }

        public ReferenceNode(GameEnums.Reference reference, List<ChipNode> from)
        {
            Reference = reference;
            From = from;
        }
    }

    private class ResourceNode : Node
    {
        public GameEnums.Resource Resource;

        public List<ChipNode> From { get; }

        public ResourceNode(GameEnums.Resource resource, List<ChipNode> from)
        {
            Resource = resource;
            From = from;
        }
    }

    private readonly TimingNode[] _timingHubs = new TimingNode[System.Enum.GetValues(typeof(GameEnums.Timing)).Length];
    private readonly ReferenceNode[] _referenceHubs = new ReferenceNode[System.Enum.GetValues(typeof(GameEnums.Reference)).Length];
    private readonly ResourceNode[] _resourceHubs = new ResourceNode[System.Enum.GetValues(typeof(GameEnums.Resource)).Length];

    private Dictionary<Chip, ChipNode> _chipToNode = new Dictionary<Chip, ChipNode>();

    /// <summary>
    /// 
    /// Boardが更新されたときのみ走るため、Boardからのみ呼ばれる。
    /// </summary>
    public void Rebuild(Dictionary<Vector2Int, Chip> chips)
    {
        // _chipToNodeのChipを削除
        _chipToNode.Clear();

        // HubのFromを全て削除
        foreach (var hub in _timingHubs)
        {
            hub.From.Clear();
        }
        foreach (var hub in _referenceHubs)
        {
            hub.From.Clear();
        }
        foreach (var hub in _resourceHubs)
        {
            hub.From.Clear();
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
        foreach (var chip in _chipToNode.Keys)
        {
            // Timingをつなぐ

            // Referenceをつなぐ
            // Resourceをつなぐ
        }

    }
}
