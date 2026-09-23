using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの離散的発動タイミングのStaminaTriggerとHPTrigger版
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTiming/ChipSettingTimingDiscreteSTOrHPT")]
public class ChipSettingTimingDiscreteSTOrHPTSO : ChipSettingTimingBaseSO
{
    [SerializeField] private List<ChipSettingTimingDiscreteSTOrHPT> _initialState;
    public override IReadOnlyList<ChipSettingTiming> InitialState => _initialState;
}
