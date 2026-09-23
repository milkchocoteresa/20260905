using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときに消費するリソース
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingResource/ChipSettingResource")]
public class ChipSettingResourceSO : ChipSettingResourceBaseSO
{
    [SerializeField] private List<ChipSettingResource> _initialState;
    public override IReadOnlyList<ChipSettingResource> InitialState => _initialState;
}
