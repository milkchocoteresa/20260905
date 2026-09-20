using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚Ì‘ÎÛ
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTarget")]
public class ChipSettingTargetSO : ScriptableObject
{
    [SerializeField] private ChipSettingTarget _initialState;
    public ChipSettingTarget InitialState => _initialState;
}
