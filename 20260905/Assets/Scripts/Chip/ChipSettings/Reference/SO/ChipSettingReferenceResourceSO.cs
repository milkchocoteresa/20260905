using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときに参照するリソース
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingReference/ChipSettingReferenceResource")]
public class ChipSettingReferenceResourceSO : ChipSettingReferenceBaseSO
{
    [SerializeField] private List<ChipSettingReferenceResource> _initialState;
    public override IReadOnlyList<ChipSettingReference> InitialState => _initialState;
}
