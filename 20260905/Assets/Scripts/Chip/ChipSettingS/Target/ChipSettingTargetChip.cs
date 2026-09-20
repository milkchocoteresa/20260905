using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果の対象となるチップ
/// </summary>
[System.Serializable]
public class ChipSettingTargetChip : ChipSettingTarget
{
    private List<Vector2Int> _chipPositions;
    public IReadOnlyList<Vector2Int> ChipPositions => _chipPositions;

    public ChipSettingTargetChip(List<Vector2Int> chipPositions)
    {
        this._chipPositions = new List<Vector2Int>(chipPositions);
    }

    public ChipSettingTargetChip(ChipSettingTargetChip orgn) : this(orgn._chipPositions)
    {

    }
}
