using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの離散的発動タイミングの情報
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTiming/ChipSettingTimingDiscrete")]
public class ChipSettingTimingDiscreteSO : ChipSettingTimingBaseSO
{
    [SerializeField] private List<ChipSettingTimingDiscrete> _initialState;
    public override IReadOnlyList<ChipSettingTiming> InitialState => _initialState;
}
