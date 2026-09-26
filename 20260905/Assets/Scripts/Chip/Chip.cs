using System.Collections.Generic;

public class Chip
{
    public Chip(ChipSettingSO setting)
    {
        Setting = setting;
        Role = setting.Type;
        Availability = setting.Availability;
        Mobility = setting.Mobility;
        Condition = setting.Condition;
        Rule = setting.ChipRule;
        ActionAvailability = GameEnums.Availability.Available;

    }

    public ChipSettingSO Setting { get; private set; }

    public GameEnums.Role Role { get; }
    public GameEnums.Availability Availability { get; private set; }
    public GameEnums.Mobility Mobility { get; private set; }
    public ChipSettingCondition Condition { get; }
    public ChipSettingRule Rule { get; }

    public GameEnums.Availability ActionAvailability { get; private set; }
    public int[] referenceCount { get; private set; }



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
