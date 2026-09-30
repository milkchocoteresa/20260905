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
        _triggerTimingReceiver = setting.TriggerTimingReceiver;
        _referenceTimingReceiver = setting.ReferenceTimingReceiver;
        _eventsCount = new int[_referenceTimingReceiver.ArrayLength];
        _triggerTimingData = new TriggerTimingData(_triggerTimingData.ThresholdCount, _triggerTimingData.AvailableActivationTimesCount);
    }

    public readonly ChipSettingSO Setting;

    public GameEnums.Role Role { get; }
    public GameEnums.Availability Availability { get; private set; }
    public GameEnums.Mobility Mobility { get; private set; }
    public readonly ChipSettingCondition Condition;
    public readonly ChipSettingRule Rule;
    private readonly TriggerTimingReceiverSO _triggerTimingReceiver;
    private readonly ReferenceTimingReceiverSO _referenceTimingReceiver;

    private readonly TriggerTimingData _triggerTimingData; // トリガータイミング用記録
    private readonly int[] _eventsCount; // 参照用タイミングの記録

    public void SetAvailability(GameEnums.Availability newAva)
    {
        Availability = newAva;
    }

    public void SetMobility(GameEnums.Mobility newMob)
    {
        Mobility = newMob;
    }

    public void Execute(TriggerContext context, List<ChipActionResult> result)
    {
        _triggerTimingReceiver.TriggerTimingReceive(_triggerTimingData, context, _eventsCount, result);
    }

    public void ReferenceEventReceive(TriggerContext context)
    {
        _referenceTimingReceiver.ReferenceTimingReceive(context, _eventsCount);
    }
}
