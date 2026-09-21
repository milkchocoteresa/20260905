using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの発動タイミング
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTiming")]
public class ChipSettingTimingSO : ScriptableObject
{
    [SerializeField] private List<ChipSettingTiming> _initialState;
    public IReadOnlyList<ChipSettingTiming> InitialState => _initialState;
}
