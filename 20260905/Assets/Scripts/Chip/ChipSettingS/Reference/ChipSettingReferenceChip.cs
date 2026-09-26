using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときに参照するチップ
/// </summary>
[System.Serializable]
public class ChipSettingReferenceChip : ChipSettingReference
{
    [SerializeField] private List<Vector2Int> _chipPositions;
    [SerializeField] private List<ChipSettingSO> _chipTypes;
    public IReadOnlyList<Vector2Int> ChipPositions => _chipPositions;
    public IReadOnlyList<ChipSettingSO> ChipTypes => _chipTypes;

    public ChipSettingReferenceChip()
    {

    }
}
