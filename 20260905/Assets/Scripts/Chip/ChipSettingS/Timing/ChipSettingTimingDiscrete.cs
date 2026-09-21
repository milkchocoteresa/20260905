using UnityEngine;
/// <summary>
/// チップの離散的発動タイミングの情報。_availableActivationTimesは-1のとき制限なし。
/// </summary>
[System.Serializable]
public class ChipSettingTimingDiscrete : ChipSettingTiming
{
    [SerializeField] private int _threshold = 1;                    // 発動までに必要な発火回数
    [SerializeField] private float _timeToActivation = 0f;          // 効果が発動するまでの秒数
    [SerializeField] private int _availableActivationTimes = -1;    // 発動可能回数

    public int Threshold => _threshold;
    public float TimeToActivation => _timeToActivation;
    public int AvailableActivationTimes => _availableActivationTimes;

    public ChipSettingTimingDiscrete(GameEnums.Timing timing, int threshold, float timeToActivation, int availableActivationTimes) : base(timing)
    {
        _threshold = threshold;
        _timeToActivation = timeToActivation;
        _availableActivationTimes = availableActivationTimes;
    }

    public ChipSettingTimingDiscrete(ChipSettingTimingDiscrete orgn) : this(orgn.Timing, orgn.Threshold, orgn.TimeToActivation, orgn.AvailableActivationTimes)
    {

    }
}
