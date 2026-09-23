using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果の対象となるチップ
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTarget/ChipSettingTargetChip")]
public class ChipSettingTargetChipSO : ChipSettingTargetBaseSO
{
    [SerializeField] private List<ChipSettingTargetChip> _initialState;
    public override IReadOnlyList<ChipSettingTarget> InitialState => _initialState;
}
