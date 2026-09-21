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
        public List<Node> TimTo { get; } = new();
        public List<Node> RefTo { get; } = new();
        public List<Node> ResTo { get; } = new();
        public List<Node> TarTo { get; } = new();

        public bool HasDynamicReference { get; set; }
    }

    private List<Chip> _chipsOnBoard = new List<Chip>();

    private List<Node> _roots = new List<Node>();


}
