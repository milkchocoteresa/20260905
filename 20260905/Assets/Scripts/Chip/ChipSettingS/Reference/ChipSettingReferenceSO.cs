using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときの参照
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingReference")]
public class ChipSettingReferenceSO : ScriptableObject
{
    [SerializeField] private List<ChipSettingReference> _initialState;
    public IReadOnlyList<ChipSettingReference> InitialState => _initialState;
}
