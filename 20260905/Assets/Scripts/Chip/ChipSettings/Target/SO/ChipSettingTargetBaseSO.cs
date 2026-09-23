using System.Collections.Generic;
using UnityEngine;

public abstract class ChipSettingTargetBaseSO : ScriptableObject
{
    public abstract IReadOnlyList<ChipSettingTarget> InitialState { get; }
}
