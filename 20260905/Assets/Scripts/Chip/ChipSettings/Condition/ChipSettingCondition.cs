using UnityEngine;

/// <summary>
/// チップ配置時に決まる、チップが有効になるための条件
/// </summary>
[System.Serializable]
public class ChipSettingCondition
{
    [SerializeField] private GameEnums.Condition _condition;
    public GameEnums.Condition Condition => _condition;

    public ChipSettingCondition()
    {

    }
}
