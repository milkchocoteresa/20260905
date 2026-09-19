/// <summary>
/// チップの効果が発動するときに参照するリソース
/// </summary>
[System.Serializable]
public class ChipSettingReferenceResource : ChipSettingReference
{
    public ChipSettingResource resource;

    public ChipSettingReferenceResource(ChipSettingResource resource)
    {
        this.resource = resource;
    }
}
