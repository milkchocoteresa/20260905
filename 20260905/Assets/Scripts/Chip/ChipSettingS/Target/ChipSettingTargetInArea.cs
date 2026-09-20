using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚Ì‘ÎÛ‚Æ‚È‚é”ÍˆÍ
/// </summary>
[System.Serializable]
public class ChipSettingTargetInArea : ChipSettingTarget
{
    public Vector2 Center { get; set; }
    public float Radius { get; set; }

    public ChipSettingTargetInArea(Vector2 center, float radius)
    {
        this.Center = center;
        this.Radius = radius;
    }

    public ChipSettingTargetInArea(ChipSettingTargetInArea orgn) : this(orgn.Center, orgn.Radius)
    {

    }
}
