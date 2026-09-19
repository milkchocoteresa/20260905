using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときに参照するチップ
/// </summary>
[System.Serializable]
public class ChipSettingReferenceChip : ChipSettingReference
{
    public List<Vector2Int> chipPositions;

    public ChipSettingReferenceChip(List<Vector2Int> chipPosition)
    {
        this.chipPositions = chipPosition;
    }
}
