/// <summary>
/// チップの連続的発動タイミングの情報
/// </summary>
[System.Serializable]
public class ChipSettingTimingContinuous : ChipSettingTiming
{
    public ChipSettingTimingDiscrete start; // 開始
    public ChipSettingTimingDiscrete end;   // 終了

    public ChipSettingTimingContinuous(ChipSettingTimingDiscrete start, ChipSettingTimingDiscrete end)
    {
        this.start = start;
        this.end = end;
    }
}
