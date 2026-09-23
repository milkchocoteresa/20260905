using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップ配置時に決まる、チップが有効になるための周囲のチップの条件
/// </summary>
public class ChipSettingConditionChip : ChipSettingCondition
{
    [SerializeField] private List<Vector2Int> _positions;
    [SerializeField] private Dictionary<ChipSettingSO, int> _chipTypesAndNums;

    public IReadOnlyList<Vector2Int> Positions => _positions;
    public IReadOnlyDictionary<ChipSettingSO, int> ChipTypesAndNums => _chipTypesAndNums;

    public ChipSettingConditionChip(GameEnums.Condition condition, IReadOnlyList<Vector2Int> positions, IReadOnlyDictionary<ChipSettingSO, int> chipTypesAndNums) : base(condition)
    {
        this._positions = new List<Vector2Int>(positions);
        _chipTypesAndNums = new Dictionary<ChipSettingSO, int>(chipTypesAndNums);
    }

    public ChipSettingConditionChip(ChipSettingConditionChip orgn) : this(orgn.Condition, orgn.Positions, orgn.ChipTypesAndNums)
    {

    }
}
