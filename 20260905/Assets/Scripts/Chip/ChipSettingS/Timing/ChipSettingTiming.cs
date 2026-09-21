using UnityEngine;

/// <summary>
/// チップの発動タイミング
/// </summary>
[System.Serializable]
public class ChipSettingTiming
{
    [SerializeField] private GameEnums.Timing _timing;
    public GameEnums.Timing Timing => _timing;

    public ChipSettingTiming(GameEnums.Timing timing)
    {
        this._timing = timing;
    }

    public ChipSettingTiming(ChipSettingTiming orgn) : this(orgn.Timing)
    {

    }
}
