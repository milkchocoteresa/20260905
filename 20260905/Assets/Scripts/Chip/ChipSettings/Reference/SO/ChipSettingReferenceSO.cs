using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときの参照
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingReference/ChipSettingReference")]
public class ChipSettingReferenceSO : ChipSettingReferenceBaseSO
{
    [SerializeField] private List<ChipSettingReference> _initialState;
    public override IReadOnlyList<ChipSettingReference> InitialState => _initialState;
}
