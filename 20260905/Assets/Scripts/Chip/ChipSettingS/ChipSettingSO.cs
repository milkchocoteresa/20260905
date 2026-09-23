using UnityEngine;

[CreateAssetMenu(menuName = "Chips/ChipSetting")]
public class ChipSettingSO : ScriptableObject
{
    [SerializeField] private GameEnums.Role _type;
    [SerializeField] private GameEnums.Availability _availability;
    [SerializeField] private GameEnums.Mobility _mobility;

    [SerializeField] private ChipSettingConditionSO _condition;
    [SerializeField] private ChipSettingTimingSO _timing;
    [SerializeField] private ChipSettingReferenceSO _reference;
    [SerializeField] private ChipSettingResourceSO _resource;
    [SerializeField] private ChipSettingTargetSO _target;

    // 見た目のスプライト追加

    public GameEnums.Role Type => _type;
    public GameEnums.Availability Availability => _availability;
    public GameEnums.Mobility Mobility => _mobility;

    public ChipSettingConditionSO Condition => _condition;
    public ChipSettingTimingSO Timing => _timing;
    public ChipSettingReferenceSO Reference => _reference;
    public ChipSettingResourceSO Resource => _resource;
    public ChipSettingTargetSO Target => _target;
}
