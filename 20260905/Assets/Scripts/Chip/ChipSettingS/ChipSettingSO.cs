using UnityEngine;

[CreateAssetMenu(menuName = "Chips/ChipSetting")]
public class ChipSettingSO : ScriptableObject
{
    [SerializeField] private GameEnums.Type _type;
    [SerializeField] private GameEnums.Availability _availability;
    [SerializeField] private GameEnums.Mobility _mobility;

    [SerializeField] private ChipSettingTimingSO _timing;
    [SerializeField] private ChipSettingReferenceSO _reference;
    [SerializeField] private ChipSettingResourceSO _resource;
    [SerializeField] private ChipSettingTargetSO _target;

    // 見た目のスプライト追加

    public GameEnums.Type Type => _type;
    public GameEnums.Availability Availability => _availability;
    public GameEnums.Mobility Mobility => _mobility;

    public ChipSettingTimingSO Timing => _timing;
    public ChipSettingReferenceSO Reference => _reference;
    public ChipSettingResourceSO Resource => _resource;
    public ChipSettingTargetSO Target => _target;
}
