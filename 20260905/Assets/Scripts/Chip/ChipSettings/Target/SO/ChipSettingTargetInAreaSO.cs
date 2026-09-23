using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果の対象となるチップ
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTarget/ChipSettingTargetInArea")]
public class ChipSettingTargetInAreaSO : ChipSettingTargetBaseSO
{
    [SerializeField] private List<ChipSettingTargetInArea> _initialState;
    public override IReadOnlyList<ChipSettingTarget> InitialState => _initialState;
}
