using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの離散的発動タイミングのChipActionTrigger版
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTiming/ChipSettingTimingDiscreteCAT")]
public class ChipSettingTimingDiscreteCATSO : ChipSettingTimingBaseSO
{
    [SerializeField] private List<ChipSettingTimingDiscreteCAT> _initialState;
    public override IReadOnlyList<ChipSettingTiming> InitialState => _initialState;
}
