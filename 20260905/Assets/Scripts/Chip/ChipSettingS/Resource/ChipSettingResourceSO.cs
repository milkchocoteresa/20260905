using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときに消費するリソース
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingResource")]
public class ChipSettingResourceSO : ScriptableObject
{
    [SerializeField] private List<ChipSettingResource> _initialState;
    public IReadOnlyList<ChipSettingResource> InitialState => _initialState;
}
