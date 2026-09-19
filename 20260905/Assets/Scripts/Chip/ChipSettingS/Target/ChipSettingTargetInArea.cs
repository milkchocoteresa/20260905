using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚Ì‘ÎÛ‚Æ‚È‚é”ÍˆÍ
/// </summary>
[System.Serializable]
public class ChipSettingTargetInArea : ChipSettingTarget
{
    public Vector2 center;
    public float radius;

    public ChipSettingTargetInArea(Vector2 center, float radius)
    {
        this.center = center;
        this.radius = radius;
    }
}
