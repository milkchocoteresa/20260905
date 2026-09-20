using UnityEngine;

/// <summary>
/// チップの発動タイミング
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingTiming")]
public class ChipSettingTimingSO : ScriptableObject
{
    [SerializeField] private ChipSettingTiming _initialState;
    public ChipSettingTiming InitialState => _initialState;
}
