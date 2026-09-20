/// <summary>
/// チップの効果が発動するときに参照するリソース
/// </summary>
[System.Serializable]
public class ChipSettingReferenceResource : ChipSettingReference
{
    public ChipSettingResource Resource { get; set; }

    public ChipSettingReferenceResource(ChipSettingResource resource)
    {
        this.Resource = new ChipSettingResource(resource);
    }

    public ChipSettingReferenceResource(ChipSettingReferenceResource orgn) : this(orgn.Resource)
    {

    }
}
