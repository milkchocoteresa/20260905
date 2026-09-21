using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    [SerializeField] private ChipSettingSO _setting;
    [SerializeField] private ChipCalculationSO _calculation;

    private void Awake()
    {
        Type = _setting.Type;
        Availability = _setting.Availability;
        Mobility = _setting.Mobility;

        TimDetail = _setting.Timing.InitialState switch
        {
            ChipSettingTimingDiscreteCAT det => new ChipSettingTimingDiscreteCAT(det),
            ChipSettingTimingDiscreteSTOrHPT det => new ChipSettingTimingDiscreteSTOrHPT(det),
            ChipSettingTimingDiscrete det => new ChipSettingTimingDiscrete(det),
            ChipSettingTimingContinuous det => new ChipSettingTimingContinuous(det),
            _ => null
        };

        RefDetail = _setting.Reference.InitialState switch
        {
            ChipSettingReferenceChip det => new ChipSettingReferenceChip(det),
            ChipSettingReferenceResource det => new ChipSettingReferenceResource(det),
            _ => null
        };

        ResDetail = _setting.Resource.InitialState switch
        {
            ChipSettingResourceMP det => new ChipSettingResourceMP(det),
            ChipSettingResourceEffect det => new ChipSettingResourceEffect(det),
            ChipSettingResource det => new ChipSettingResource(det),
            _ => null
        };

        TarDetail = _setting.Target.InitialState switch
        {
            ChipSettingTargetChip det => new ChipSettingTargetChip(det),
            ChipSettingTargetInArea det => new ChipSettingTargetInArea(det),
            _ => null
        };
    }

    public GameEnums.Type Type { get; private set; }
    public GameEnums.Availability Availability { get; private set; }
    public GameEnums.Mobility Mobility { get; private set; }
    public ChipSettingTiming TimDetail { get; private set; }
    public ChipSettingReference RefDetail { get; private set; }
    public ChipSettingResource ResDetail { get; private set; }
    public ChipSettingTarget TarDetail { get; private set; }

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
