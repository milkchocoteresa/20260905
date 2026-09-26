using UnityEngine;
/// <summary>
/// チップの離散的発動タイミングのStaminaTriggerとHPTrigger版
/// </summary>
[System.Serializable]
public class TimingDetailSTOrHPT : TimingDetail
{
    [SerializeField] private int _rate;                 // スタミナまたはHPの発火タイミングとなる割合
    [SerializeField] private GameEnums.Inequalities _inequality;  // 上記の割合に対する不等式
    [SerializeField] private bool _availability;        // 発火可能かどうか

    public int Rate => _rate;
    public GameEnums.Inequalities Inequality => _inequality;
    public bool Availability => _availability;

    public TimingDetailSTOrHPT()
    {

    }
}
