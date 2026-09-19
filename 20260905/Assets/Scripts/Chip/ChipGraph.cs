using System.Collections.Generic;

/// <summary>
/// 回路をグラフで整理する。
/// イベントキューを持ち、スケジューラーとしてチップの効果の発動の管理をする。
/// </summary>
public class ChipGraph
{
    private class Node
    {
        public Chip Chip { get; }
        public List<Node> TriggerChipTo { get; } = new();
        public List<Node> ReferenceChipTo { get; } = new();
        public List<Node> CostChipTo { get; } = new();
        public List<Node> ActionChipTo { get; } = new();

        public bool HasDynamicReference { get; set; }
    }

    private List<Chip> _chipsOnBoard;

    private List<Node> _roots;


}
