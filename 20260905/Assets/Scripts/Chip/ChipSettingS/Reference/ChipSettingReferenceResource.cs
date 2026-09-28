using UnityEngine;
/// <summary>
/// チップの効果が発動するときに参照するリソース
/// </summary>
[System.Serializable]
public class ChipSettingReferenceResource : ChipSettingReference
{
    [SerializeField] private GameEnums.Resource _resource;
    public GameEnums.Resource Resource => _resource;

    public ChipSettingReferenceResource()
    {

    }
}
