using System.Collections.Generic;

/// <summary>
/// 回路をグラフで整理する。
/// イベントキューを持ち、スケジューラーとしてチップの効果の発動の管理をする。
/// </summary>
public class ChipGraph
{
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

        public List<ChipNode> From;

        public ReferenceNode(GameEnums.Reference reference, List<ChipNode> from)
        {
            Reference = reference;
            From = from;
        }
    }

    private class ResourceNode : Node
    {
        public GameEnums.Resource Resource;

        public List<ChipNode> From;

        public ResourceNode(GameEnums.Resource resource, List<ChipNode> from)
        {
            Resource = resource;
            From = from;
        }
    }

    private TimingNode _timHit = new TimingNode(GameEnums.Timing.Hit, new List<ChipNode>());
    private TimingNode _timTakeDamage = new TimingNode(GameEnums.Timing.TakeDamage, new List<ChipNode>());
    private TimingNode _timOrbTrigger = new TimingNode(GameEnums.Timing.OrbTrigger, new List<ChipNode>());
    private TimingNode _timStaminaTrigger = new TimingNode(GameEnums.Timing.StaminaTrigger, new List<ChipNode>());
    private TimingNode _timHPTrigger = new TimingNode(GameEnums.Timing.HPTrigger, new List<ChipNode>());

    private ReferenceNode _refMP = new ReferenceNode(GameEnums.Reference.MP, new List<ChipNode>());
    private ReferenceNode _refStamina = new ReferenceNode(GameEnums.Reference.Stamina, new List<ChipNode>());
    private ReferenceNode _refHP = new ReferenceNode(GameEnums.Reference.HP, new List<ChipNode>());
    private ReferenceNode _refEnemy = new ReferenceNode(GameEnums.Reference.Enemy, new List<ChipNode>());

    private ResourceNode _resMP = new ResourceNode(GameEnums.Resource.MP, new List<ChipNode>());
    private ResourceNode _resStamina = new ResourceNode(GameEnums.Resource.Stamina, new List<ChipNode>());
    private ResourceNode _resHP = new ResourceNode(GameEnums.Resource.HP, new List<ChipNode>());
    private ResourceNode _resEffect = new ResourceNode(GameEnums.Resource.Effect, new List<ChipNode>());

    private Dictionary<Chip, Node> _chipToNode = new Dictionary<Chip, Node>();

    public void BoardUpdate(Chip removed, Chip attached)
    {
        if (removed != null)
        {

        }
    }
}
