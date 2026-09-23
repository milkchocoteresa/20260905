using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    [SerializeField] private ChipSettingSO _setting;
    [SerializeField] private ChipCalculationSO _calculation;

    private void Awake()
    {
        Role = _setting.Type;
        Availability = _setting.Availability;
        Mobility = _setting.Mobility;

        Condition = _setting.Condition.InitialState switch
        {
            ChipSettingConditionChip con => new ChipSettingConditionChip(con),
            _ => null,
        };

        Timings = _setting.Timing.InitialState switch
        {
            List<ChipSettingTimingDiscreteCAT> tim => new List<ChipSettingTimingDiscreteCAT>(tim),
            List<ChipSettingTimingDiscreteSTOrHPT> tim => new List<ChipSettingTimingDiscreteSTOrHPT>(tim),
            List<ChipSettingTimingDiscrete> tim => new List<ChipSettingTimingDiscrete>(tim),
            List<ChipSettingTimingContinuous> tim => new List<ChipSettingTimingContinuous>(tim),
            _ => null
        };

        References = _setting.Reference.InitialState switch
        {
            List<ChipSettingReferenceChip> refe => new List<ChipSettingReferenceChip>(refe),
            List<ChipSettingReferenceResource> refe => new List<ChipSettingReferenceResource>(refe),
            _ => null
        };

        Resources = _setting.Resource.InitialState switch
        {
            List<ChipSettingResourceMP> res => new List<ChipSettingResourceMP>(res),
            List<ChipSettingResourceEffect> res => new List<ChipSettingResourceEffect>(res),
            List<ChipSettingResource> res => new List<ChipSettingResource>(res),
            _ => null
        };

        Targets = _setting.Target.InitialState switch
        {
            List<ChipSettingTargetChip> tar => new List<ChipSettingTargetChip>(tar),
            List<ChipSettingTargetInArea> tar => new List<ChipSettingTargetInArea>(tar),
            _ => null
        };
    }

    public GameEnums.Role Role { get; private set; }
    public GameEnums.Availability Availability { get; private set; }
    public GameEnums.Mobility Mobility { get; private set; }

    public ChipSettingCondition Condition { get; private set; }
    public IReadOnlyList<ChipSettingTiming> Timings { get; private set; }
    public IReadOnlyList<ChipSettingReference> References { get; private set; }
    public IReadOnlyList<ChipSettingResource> Resources { get; private set; }
    public IReadOnlyList<ChipSettingTarget> Targets { get; private set; }

    public void SetAvailability(GameEnums.Availability newAva)
    {
        Availability = newAva;
    }

    public void SetMobility(GameEnums.Mobility newMob)
    {
        Mobility = newMob;
    }

    public void Execute(ChipExecutionContext context, List<ChipActionResult> result)
    {
        _calculation.Calculate(context, result);
    }
}
