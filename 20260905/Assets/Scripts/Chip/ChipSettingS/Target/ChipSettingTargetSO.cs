using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ƒ`ƒbƒv‚ÌŒø‰Ê‚Ì‘ÎÛ
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTarget")]
public class ChipSettingTargetSO : ScriptableObject
{
    [SerializeField] private List<ChipSettingTarget> _initialState;
    public IReadOnlyList<ChipSettingTarget> InitialState => _initialState;
}
