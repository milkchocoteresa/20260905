using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの発動タイミング
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTiming/ChipSettingTiming")]
public class ChipSettingTimingSO : ChipSettingTimingBaseSO
{
    [SerializeField] private List<ChipSettingTiming> _initialState;
    public override IReadOnlyList<ChipSettingTiming> InitialState => _initialState;
}
