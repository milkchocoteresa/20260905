/// <summary>
/// チップの離散的発動タイミングの情報。_availableActivationTimesは-1のとき制限なし。
/// </summary>
[System.Serializable]
public class ChipSettingTimingDiscrete : ChipSettingTiming
{
    public int _threshold = 1;                  // 発動までに必要な発火回数
    public float _timeToActivation = 0;         // 効果が発動するまでの秒数
    public int _availableActivationTimes = -1;  // 発動可能回数

    public ChipSettingTimingDiscrete(int threshold, float timeToActivation, int availableActivationTimes)
    {
        _threshold = threshold;
        _timeToActivation = timeToActivation;
        _availableActivationTimes = availableActivationTimes;
    }
}
