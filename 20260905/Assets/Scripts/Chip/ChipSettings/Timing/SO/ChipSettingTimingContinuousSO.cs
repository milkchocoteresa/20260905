using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの連続的発動タイミングの情報
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTiming/ChipSettingTimingContinuous")]
public class ChipSettingTimingContinuousSO : ChipSettingTimingBaseSO
{
    [SerializeField] private List<ChipSettingTimingContinuous> _initialState;
    public override IReadOnlyList<ChipSettingTiming> InitialState => _initialState;
}
