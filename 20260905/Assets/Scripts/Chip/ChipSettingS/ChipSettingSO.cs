using UnityEngine;

[CreateAssetMenu(menuName = "Chips/ChipSetting")]
public class ChipSettingSO : ScriptableObject
{
    [SerializeField] private Chip.Availability _availability;
    [SerializeField] private Chip.Mobility _mobility;

    [SerializeField] private Chip.Timing _timing;
    [SerializeField] private ChipSettingTimingSO _timDetail;

    [SerializeField] private Chip.Reference _reference;
    [SerializeField] private ChipSettingReferenceSO _refDetail;

    [SerializeField] private Chip.Resource _resourceConsumption;
    [SerializeField] private ChipSettingResourceSO _rCDetail;

    [SerializeField] private Chip.Target _target;
    [SerializeField] private ChipSettingTargetSO _tarDetail;

    // 見た目のスプライト追加

    public Chip.Availability Availability => _availability;
    public Chip.Mobility Mobility => _mobility;

    public Chip.Timing Timing => _timing;
    public ChipSettingTimingSO TimDetail => _timDetail;

    public Chip.Reference Reference => _reference;
    public ChipSettingReferenceSO RefDetail => _refDetail;

    public Chip.Resource ResourceConsumption => _resourceConsumption;
    public ChipSettingResourceSO RCDetail => _rCDetail;

    public Chip.Target Target => _target;
    public ChipSettingTargetSO TarDetail => _tarDetail;
}
