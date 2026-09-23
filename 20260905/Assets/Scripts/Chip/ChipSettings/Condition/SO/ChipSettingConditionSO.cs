using UnityEngine;

/// <summary>
/// チップ配置時に決まる、チップが有効になるための条件
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingCondition/ChipSettingConditionChip")]
public class ChipSettingConditionSO : ChipSettingConditionBaseSO
{
    [SerializeField] private ChipSettingCondition _initialState;
    public override ChipSettingCondition InitialState => _initialState;
}
