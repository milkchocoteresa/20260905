using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果の対象となるチップ
/// </summary>
[System.Serializable]
public class ChipSettingTargetChip : ChipSettingTarget
{
    [SerializeField] private List<Vector2Int> _chipPositions;
    public IReadOnlyList<Vector2Int> ChipPositions => _chipPositions;

    public ChipSettingTargetChip()
    {

    }
}
