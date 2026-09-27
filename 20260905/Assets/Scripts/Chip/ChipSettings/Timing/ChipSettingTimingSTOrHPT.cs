using UnityEngine;

public class ChipSettingTimingSTOrHPT : ChipSettingTiming
{
    [SerializeField] private int ratio; // 0-100%
    [SerializeField] private GameEnums.Inequality _inequality;

    public int Ratio => ratio;
    public GameEnums.Inequality Inequality => _inequality;
}
