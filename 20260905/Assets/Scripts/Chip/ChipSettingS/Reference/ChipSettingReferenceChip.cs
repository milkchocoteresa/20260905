using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときに参照するチップ
/// </summary>
[System.Serializable]
public class ChipSettingReferenceChip : ChipSettingReference
{
    private List<Vector2Int> _chipPositions;
    public IReadOnlyList<Vector2Int> ChipPositions => _chipPositions;

    public ChipSettingReferenceChip(IReadOnlyList<Vector2Int> chipPosition)
    {
        this._chipPositions = new List<Vector2Int>(chipPosition);
    }

    public ChipSettingReferenceChip(ChipSettingReferenceChip orgn) : this(orgn.ChipPositions)
    {

    }
}
