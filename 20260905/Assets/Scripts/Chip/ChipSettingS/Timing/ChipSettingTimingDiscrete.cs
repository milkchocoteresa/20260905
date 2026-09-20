/// <summary>
/// チップの離散的発動タイミングの情報。_availableActivationTimesは-1のとき制限なし。
/// </summary>
[System.Serializable]
public class ChipSettingTimingDiscrete : ChipSettingTiming
{
    public int Threshold { get; set; } = 1;                  // 発動までに必要な発火回数
    public float TimeToActivation { get; set; } = 0;         // 効果が発動するまでの秒数
    public int AvailableActivationTimes { get; set; } = -1;  // 発動可能回数

    public ChipSettingTimingDiscrete(int threshold, float timeToActivation, int availableActivationTimes)
    {
        Threshold = threshold;
        TimeToActivation = timeToActivation;
        AvailableActivationTimes = availableActivationTimes;
    }

    public ChipSettingTimingDiscrete(ChipSettingTimingDiscrete orgn) : this(orgn.Threshold, orgn.TimeToActivation, orgn.AvailableActivationTimes)
    {

    }
}
