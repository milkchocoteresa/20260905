using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの離散的発動タイミングのChipActionTrigger版
/// </summary>
[System.Serializable]
public class ChipSettingTimingDiscreteCAT : ChipSettingTimingDiscrete
{
    public List<Vector2Int> ChipPositions;

    public ChipSettingTimingDiscreteCAT(List<Vector2Int> chipPositions, int threshold, float timeToActivation, int availableActivationTimes) : base(threshold, timeToActivation, availableActivationTimes)
    {
        ChipPositions = chipPositions;
    }
}
