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

    public ChipSettingReferenceChip(GameEnums.Reference reference, IReadOnlyList<Vector2Int> chipPosition, IReadOnlyList<ChipSettingSO> chipTypes) : base(reference)
    {
        this._chipPositions = new List<Vector2Int>(chipPosition);
        this._chipTypes = new List<ChipSettingSO>(chipTypes);
    }

    public ChipSettingReferenceChip(ChipSettingReferenceChip orgn) : this(orgn.Reference, orgn.ChipPositions, orgn._chipTypes)
    {

    }
}
