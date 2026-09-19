using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果の対象となるチップ
/// </summary>
[System.Serializable]
public class ChipSettingTargetChip : ChipSettingTarget
{
    public List<Vector2Int> chipPositions;

    public ChipSettingTargetChip(List<Vector2Int> chipPosition)
    {
        this.chipPositions = chipPosition;
    }
}
