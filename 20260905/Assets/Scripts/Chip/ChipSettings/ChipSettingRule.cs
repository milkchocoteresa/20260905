using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚ð‚Ü‚Æ‚ß‚½‚à‚Ì
/// </summary>
[System.Serializable]
public class ChipSettingRule
{
    [SerializeReference, SubclassSelector] private ChipSettingTiming _triggerTiming;
    [SerializeReference, SubclassSelector] private List<ChipSettingTiming> _referenceTimings;
    [SerializeReference, SubclassSelector] private List<ChipSettingReference> _references;
    [SerializeReference, SubclassSelector] private List<ChipSettingResource> _resources;
    [SerializeReference, SubclassSelector] private ChipSettingTarget _target;

    public ChipSettingTiming TriggerTiming => _triggerTiming;
    public IReadOnlyList<ChipSettingTiming> ReferenceTimings => _referenceTimings;
    public IReadOnlyList<ChipSettingReference> References => _references;
    public IReadOnlyList<ChipSettingResource> Resource => _resources;
    public ChipSettingTarget Target => _target;
}
