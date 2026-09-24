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
