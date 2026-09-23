using UnityEngine;

/// <summary>
/// チップ配置時に決まる、チップが有効になるための周囲のチップの条件
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingCondition/ChipSettingConditionChip")]
public class ChipSettingConditionChipSO : ChipSettingConditionBaseSO
{
    [SerializeField] private ChipSettingConditionChip _initialState;
    public override ChipSettingCondition InitialState => _initialState;
}
