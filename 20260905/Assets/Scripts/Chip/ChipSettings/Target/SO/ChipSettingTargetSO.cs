using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚Ì‘ÎÛ
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTarget/ChipSettingTarget")]
public class ChipSettingTargetSO : ChipSettingTargetBaseSO
{
    [SerializeField] private List<ChipSettingTarget> _initialState;
    public override IReadOnlyList<ChipSettingTarget> InitialState => _initialState;
}
