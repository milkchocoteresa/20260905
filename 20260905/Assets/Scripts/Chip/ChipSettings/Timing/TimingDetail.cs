using UnityEngine;

/// <summary>
/// チップの発動タイミング
/// </summary>
[System.Serializable]
public class TimingDetail
{
    [SerializeField] private GameEnums.Timing _timing;
    public GameEnums.Timing Timing => _timing;

    [SerializeField] private int _threshold = 1;                    // 発動までに必要な発火回数
    [SerializeField] private float _timeToActivation = 0f;          // 効果が発動するまでの秒数
    [SerializeField] private int _availableActivationTimes = -1;    // 発動可能回数

    public int Threshold => _threshold;
    public float TimeToActivation => _timeToActivation;
    public int AvailableActivationTimes => _availableActivationTimes;

    public TimingDetail()
    {

    }
}
