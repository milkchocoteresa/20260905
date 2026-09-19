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

    public int rate;
    public Inequalities inequalities;
    public bool availability;

    public ChipSettingTimingDiscreteSTOrHPT(int rate, Inequalities inequalities, bool availability, int threshold, float timeToActivation, int availableActivationTimes) : base(threshold, timeToActivation, availableActivationTimes)
    {
        this.rate = rate;
        this.inequalities = inequalities;
        this.availability = availability;
    }
}
