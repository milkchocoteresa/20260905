using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚ª”­“®‚·‚é‚Æ‚«‚ÉÁ”ï‚·‚éMP
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingResource/ChipSettingResourceMP")]
public class ChipSettingResourceMPSO : ChipSettingResourceBaseSO
{
    [SerializeField] private List<ChipSettingResourceMP> _initialState;
    public override IReadOnlyList<ChipSettingResource> InitialState => _initialState;
}
