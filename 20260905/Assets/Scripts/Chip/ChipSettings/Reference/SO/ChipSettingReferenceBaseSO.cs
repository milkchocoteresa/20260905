using System.Collections.Generic;
using UnityEngine;

public abstract class ChipSettingReferenceBaseSO : ScriptableObject
{
    public abstract IReadOnlyList<ChipSettingReference> InitialState { get; }
}
