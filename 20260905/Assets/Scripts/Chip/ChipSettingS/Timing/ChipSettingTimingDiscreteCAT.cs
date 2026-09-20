using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの離散的発動タイミングのChipActionTrigger版
/// </summary>
[System.Serializable]
public class ChipSettingTimingDiscreteCAT : ChipSettingTimingDiscrete
{
    private List<Vector2Int> _chipPositions;
    public IReadOnlyList<Vector2Int> ChipPositions => _chipPositions;

    public ChipSettingTimingDiscreteCAT(List<Vector2Int> chipPositions, int threshold, float timeToActivation, int availableActivationTimes) : base(threshold, timeToActivation, availableActivationTimes)
    {
        _chipPositions = new List<Vector2Int>(chipPositions);
    }

    public ChipSettingTimingDiscreteCAT(ChipSettingTimingDiscreteCAT orgn) : this(orgn._chipPositions, orgn.Threshold, orgn.TimeToActivation, orgn.AvailableActivationTimes)
    {

    }
}
