using UnityEngine;

/// <summary>
/// チップ配置時に決まる、チップが有効になるための条件
/// </summary>
[System.Serializable]
public class ChipSettingCondition
{
    [SerializeField] private GameEnums.Condition _condition;
    public GameEnums.Condition Condition => _condition;

    public ChipSettingCondition(GameEnums.Condition condition)
    {
        this._condition = condition;
    }

    public ChipSettingCondition(ChipSettingCondition orgn) : this(orgn.Condition)
    {

    }
}
