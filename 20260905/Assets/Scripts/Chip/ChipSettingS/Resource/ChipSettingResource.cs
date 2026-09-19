/// <summary>
/// チップの効果が発動するときに消費するリソース
/// </summary>
[System.Serializable]
public class ChipSettingResource
{
    public int consumptionAmount;

    public ChipSettingResource(int consumptionAmount)
    {
        this.consumptionAmount = consumptionAmount;
    }
}
