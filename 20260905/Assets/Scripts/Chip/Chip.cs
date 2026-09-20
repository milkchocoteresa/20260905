using System.Collections.Generic;
using UnityEngine;

public class Chip : MonoBehaviour
{
    [SerializeField]
    private ChipSettingSO _setting;
    [SerializeField]
    private ChipCalculationSO _calculation;

    private void Awake()
    {
        Availability = _setting.Availability;
        Mobility = _setting.Mobility;

        Timing = _setting.Timing;
        TimDetail = _setting.TimDetail.InitialState switch
        {
            ChipSettingTimingDiscreteCAT det => new ChipSettingTimingDiscreteCAT(det),
            ChipSettingTimingDiscreteSTOrHPT det => new ChipSettingTimingDiscreteSTOrHPT(det),
            ChipSettingTimingDiscrete det => new ChipSettingTimingDiscrete(det),
            ChipSettingTimingContinuous det => new ChipSettingTimingContinuous(det),
            _ => null
        };

        Reference = _setting.Reference;
        RefDetail = _setting.RefDetail.InitialState switch
        {
            ChipSettingReferenceChip det => new ChipSettingReferenceChip(det),
            ChipSettingReferenceResource det => new ChipSettingReferenceResource(det),
            _ => null
        };

        Resource = _setting.Resource;
        ResDetail = _setting.ResDetail.InitialState switch
        {
            ChipSettingResourceMP det => new ChipSettingResourceMP(det),
            ChipSettingResourceEffect det => new ChipSettingResourceEffect(det),
            ChipSettingResource det => new ChipSettingResource(det),
            _ => null
        };

        Target = _setting.Target;
        TarDetail = _setting.TarDetail.InitialState switch
        {
            ChipSettingTargetChip det => new ChipSettingTargetChip(det),
            ChipSettingTargetInArea det => new ChipSettingTargetInArea(det),
            _ => null
        };
    }

    public GameEnums.Availability Availability { get; private set; }
    public GameEnums.Mobility Mobility { get; private set; }

    public GameEnums.Timing Timing { get; private set; }
    public ChipSettingTiming TimDetail { get; private set; }

    public GameEnums.Reference Reference { get; private set; }
    public ChipSettingReference RefDetail { get; private set; }

    public GameEnums.Resource Resource { get; private set; }
    public ChipSettingResource ResDetail { get; private set; }

    public GameEnums.Target Target { get; private set; }
    public ChipSettingTarget TarDetail { get; private set; }

    public void SetAvailability(GameEnums.Availability newAva)
    {
        Availability = newAva;
    }

    public void SetMobility(GameEnums.Mobility newMob)
    {
        Mobility = newMob;
    }

    public void SetTiming(GameEnums.Timing newTim)
    {
        Timing = newTim;
    }

    public void SetReference(GameEnums.Reference newRef)
    {
        Reference = newRef;
    }

    public void SetResourceConsumption(GameEnums.Resource newRes)
    {
        Resource = newRes;
    }

    public void SetTarget(GameEnums.Target newTar)
    {
        Target = newTar;
    }

    public void Execute(ChipExecutionContext context, List<ChipActionResult> result)
    {
        _calculation.Calculate(context, result);
    }
}
