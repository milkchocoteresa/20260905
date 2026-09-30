using UnityEngine;

[System.Serializable]
public abstract class ChipSettingTiming
{
    [SerializeField] private GameEnums.Timing _timing;

    public GameEnums.Timing Timing => _timing;
}
