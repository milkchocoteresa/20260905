using System.Collections.Generic;
using UnityEngine;

public abstract class ChipSettingResourceBaseSO : ScriptableObject
{
    public abstract IReadOnlyList<ChipSettingResource> InitialState { get; }
}
