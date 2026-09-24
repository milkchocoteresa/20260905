using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚ð‚Ü‚Æ‚ß‚½‚à‚Ì
/// </summary>
[System.Serializable]
public class ChipRule
{
    [SerializeReference] private ChipSettingTiming _timing = new ChipSettingTiming(GameEnums.Timing.None);
    [SerializeReference] private List<ChipSettingReference> _reference;
    [SerializeReference] private List<ChipSettingResource> _resource;
    [SerializeReference] private ChipSettingTarget _target;
    [SerializeField] private ChipCalculationSO _calculation;

    public ChipSettingTiming Timing => _timing;
    public IReadOnlyList<ChipSettingReference> References => _reference;
    public IReadOnlyList<ChipSettingResource> Resource => _resource;
    public ChipSettingTarget Target => _target;
    public ChipCalculationSO Calculation => _calculation;
}
