using UnityEngine;

[CreateAssetMenu(menuName = "Chips/ChipSetting")]
public class ChipSettingSO : ScriptableObject
{
    [SerializeField] private GameEnums.Availability _availability;
    [SerializeField] private GameEnums.Mobility _mobility;

    [SerializeField] private GameEnums.Timing _timing;
    [SerializeField] private ChipSettingTimingSO _timDetail;

    [SerializeField] private GameEnums.Reference _reference;
    [SerializeField] private ChipSettingReferenceSO _refDetail;

    [SerializeField] private GameEnums.Resource _resource;
    [SerializeField] private ChipSettingResourceSO _resDetail;

    [SerializeField] private GameEnums.Target _target;
    [SerializeField] private ChipSettingTargetSO _tarDetail;

    // 見た目のスプライト追加

    public GameEnums.Availability Availability => _availability;
    public GameEnums.Mobility Mobility => _mobility;

    public GameEnums.Timing Timing => _timing;
    public ChipSettingTimingSO TimDetail => _timDetail;

    public GameEnums.Reference Reference => _reference;
    public ChipSettingReferenceSO RefDetail => _refDetail;

    public GameEnums.Resource Resource => _resource;
    public ChipSettingResourceSO ResDetail => _resDetail;

    public GameEnums.Target Target => _target;
    public ChipSettingTargetSO TarDetail => _tarDetail;
}
