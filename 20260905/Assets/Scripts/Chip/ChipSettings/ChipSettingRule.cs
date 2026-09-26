using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚ð‚Ü‚Æ‚ß‚½‚à‚Ì
/// </summary>
[System.Serializable]
public class ChipSettingRule
{
    [SerializeReference, SubclassSelector] private ChipSettingTiming _timing;
    [SerializeReference, SubclassSelector] private List<ChipSettingReference> _references;
    [SerializeReference, SubclassSelector] private List<ChipSettingResource> _resources;
    [SerializeReference, SubclassSelector] private ChipSettingTarget _target;
    [SerializeField] private ChipCalculationSO _calculation;

    public ChipSettingTiming Timing => _timing;
    public IReadOnlyList<ChipSettingReference> References => _references;
    public IReadOnlyList<ChipSettingResource> Resource => _resources;
    public ChipSettingTarget Target => _target;
    public ChipCalculationSO Calculation => _calculation;
}
