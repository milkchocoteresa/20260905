using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚Ì‘ÎÛ‚Æ‚È‚é”ÍˆÍ
/// </summary>
[System.Serializable]
public class ChipSettingTargetInArea : ChipSettingTarget
{
    [SerializeField] private Vector2 _center;
    [SerializeField] private float _radius;

    public Vector2 Center => _center;
    public float Radius => _radius;

    public ChipSettingTargetInArea()
    {

    }
}
