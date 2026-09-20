/// <summary>
/// チップの連続的発動タイミングの情報
/// </summary>
[System.Serializable]
public class ChipSettingTimingContinuous : ChipSettingTiming
{
    public ChipSettingTimingDiscrete Start { get; set; }    // 開始
    public ChipSettingTimingDiscrete End { get; set; }      // 終了

    public ChipSettingTimingContinuous(ChipSettingTimingDiscrete start, ChipSettingTimingDiscrete end)
    {
        this.Start = new ChipSettingTimingDiscrete(start);
        this.End = new ChipSettingTimingDiscrete(end);
    }

    public ChipSettingTimingContinuous(ChipSettingTimingContinuous orgn) : this(orgn.Start, orgn.End)
    {

    }
}
