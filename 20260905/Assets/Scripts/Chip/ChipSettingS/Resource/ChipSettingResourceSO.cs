using UnityEngine;

/// <summary>
/// チップの効果が発動するときに消費するリソース
/// </summary>
[CreateAssetMenu(menuName = "Chips/ChipSettingResource")]
public class ChipSettingResourceSO : ScriptableObject
{
    [SerializeField] private ChipSettingResource _initialState;
}
