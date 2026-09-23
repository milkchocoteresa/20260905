using System.Collections.Generic;
using UnityEngine;

public abstract class ChipSettingTimingBaseSO : ScriptableObject
{
    public abstract IReadOnlyList<ChipSettingTiming> InitialState { get; }
}
