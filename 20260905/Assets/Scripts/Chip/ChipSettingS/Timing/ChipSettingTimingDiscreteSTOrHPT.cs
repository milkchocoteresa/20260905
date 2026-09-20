/// <summary>
/// チップの離散的発動タイミングのStaminaTriggerとHPTrigger版
/// </summary>
[System.Serializable]
public class ChipSettingTimingDiscreteSTOrHPT : ChipSettingTimingDiscrete
{
    public enum Inequalities
    {
        AtLeast,    // 以上
        AtMost,     // 以下
        MoreThan,   // より上
        LessThan    // 未満
    }

    public int rate { get; set; }
    public Inequalities inequality { get; set; }
    public bool availability { get; set; }

    public ChipSettingTimingDiscreteSTOrHPT(int rate, Inequalities inequality, bool availability, int threshold, float timeToActivation, int availableActivationTimes) : base(threshold, timeToActivation, availableActivationTimes)
    {
        this.rate = rate;
        this.inequality = inequality;
        this.availability = availability;
    }

    public ChipSettingTimingDiscreteSTOrHPT(ChipSettingTimingDiscreteSTOrHPT orgn) : this(orgn.rate, orgn.inequality, orgn.availability, orgn.Threshold, orgn.TimeToActivation, orgn.AvailableActivationTimes)
    {

    }
}
