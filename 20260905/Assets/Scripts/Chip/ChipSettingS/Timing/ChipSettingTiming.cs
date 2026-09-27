using UnityEngine;

[System.Serializable]
public abstract class ChipSettingTiming
{
    [SerializeField] private GameEnums.Timing _timing;
    [SerializeField] private int _threshold = 1;                    // ”­“®‚Ü‚Å‚É•K—v‚È”­‰Î‰ñ”
    [SerializeField] private float _timeToActivation = 0f;          // Œø‰Ê‚ª”­“®‚·‚é‚Ü‚Å‚Ì•b”
    [SerializeField] private int _availableActivationTimes = -1;    // ”­“®‰Â”\‰ñ”

    public GameEnums.Timing Timing => _timing;
    public int Threshold => _threshold;
    public float TimeToActivation => _timeToActivation;
    public int AvailableActivationTimes => _availableActivationTimes;
}
