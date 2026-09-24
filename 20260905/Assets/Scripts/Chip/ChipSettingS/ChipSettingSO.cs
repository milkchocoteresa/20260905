using UnityEngine;

[CreateAssetMenu(menuName = "Chips/ChipSetting")]
public class ChipSettingSO : ScriptableObject
{
    [SerializeField] private GameEnums.Role _type;
    [SerializeField] private GameEnums.Availability _availability;
    [SerializeField] private GameEnums.Mobility _mobility;

    [SerializeReference] private ChipSettingConditionSO _condition;

    [SerializeField] private ChipRule _chipRule;

    // 見た目のスプライト追加

    public GameEnums.Role Type => _type;
    public GameEnums.Availability Availability => _availability;
    public GameEnums.Mobility Mobility => _mobility;

    public ChipSettingConditionSO Condition => _condition;
    public ChipRule ChipRule => _chipRule;
}
