using UnityEngine;
/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚Ì‘ÎÛ
/// </summary>
[System.Serializable]
public class ChipSettingTarget
{
    [SerializeField] private GameEnums.Target _target;
    public GameEnums.Target Target => _target;

    public ChipSettingTarget(GameEnums.Target target)
    {
        this._target = target;
    }

    public ChipSettingTarget(ChipSettingTarget orgn) : this(orgn.Target)
    {

    }
}
