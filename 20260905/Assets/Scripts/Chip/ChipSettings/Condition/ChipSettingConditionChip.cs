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

    public ChipSettingConditionChip()
    {

    }
}
