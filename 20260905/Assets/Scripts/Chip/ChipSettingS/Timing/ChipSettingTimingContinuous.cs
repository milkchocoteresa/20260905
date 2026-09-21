using UnityEngine;

/// <summary>
/// チップの連続的発動タイミングの情報
/// </summary>
[System.Serializable]
public class ChipSettingTimingContinuous : ChipSettingTiming
{
    [SerializeField] private ChipSettingTimingDiscrete _start;  // 開始
    [SerializeField] private ChipSettingTimingDiscrete _end;    // 終了
    public ChipSettingTimingDiscrete Start => _start;
    public ChipSettingTimingDiscrete End => _end;

    public ChipSettingTimingContinuous(GameEnums.Timing timing, ChipSettingTimingDiscrete start, ChipSettingTimingDiscrete end) : base(timing)
    {
        this._start = new ChipSettingTimingDiscrete(start);
        this._end = new ChipSettingTimingDiscrete(end);
    }

    public ChipSettingTimingContinuous(ChipSettingTimingContinuous orgn) : this(orgn.Timing, orgn.Start, orgn.End)
    {

    }
}
