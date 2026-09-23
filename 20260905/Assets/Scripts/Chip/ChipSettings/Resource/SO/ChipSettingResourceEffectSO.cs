using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの効果が発動するときに消費するエフェクト
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingResource/ChipSettingResourceEffect")]
public class ChipSettingResourceEffectSO : ChipSettingResourceBaseSO
{
    [SerializeField] private List<ChipSettingResourceEffect> _initialState;
    public override IReadOnlyList<ChipSettingResource> InitialState => _initialState;
}
