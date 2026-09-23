using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときに参照するチップ
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingReference/ChipSettingReferenceChip")]
public class ChipSettingReferenceChipSO : ChipSettingReferenceBaseSO
{
    [SerializeField] private List<ChipSettingReferenceChip> _initialState;
    public override IReadOnlyList<ChipSettingReference> InitialState => _initialState;
}
