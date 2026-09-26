using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChipSettingTiming
{
    [SerializeReference, SubclassSelector] private TimingDetail _trigger;
    [SerializeReference, SubclassSelector] private TimingDetail _enable;
    [SerializeReference, SubclassSelector] private TimingDetail _disable;
    [SerializeReference, SubclassSelector] private List<TimingDetail> _reference;

    public TimingDetail Trigger => _trigger;
    public TimingDetail Enable => _enable;
    public TimingDetail Disable => _disable;
    public IReadOnlyList<TimingDetail> Reference => _reference;

    public ChipSettingTiming()
    {

    }
}
