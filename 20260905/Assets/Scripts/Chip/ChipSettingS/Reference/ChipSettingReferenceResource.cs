using UnityEngine;
/// <summary>
/// チップの効果が発動するときに参照するリソース
/// </summary>
[System.Serializable]
public class ChipSettingReferenceResource : ChipSettingReference
{
    [SerializeField] private ChipSettingResource _resource;
    public ChipSettingResource Resource => _resource;

    public ChipSettingReferenceResource(GameEnums.Reference reference, ChipSettingResource resource) : base(reference)
    {
        this._resource = new ChipSettingResource(resource);
    }

    public ChipSettingReferenceResource(ChipSettingReferenceResource orgn) : this(orgn.Reference, orgn.Resource)
    {

    }
}
