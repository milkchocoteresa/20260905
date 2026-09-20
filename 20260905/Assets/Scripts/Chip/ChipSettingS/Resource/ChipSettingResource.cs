/// <summary>
/// チップの効果が発動するときに消費するリソース
/// </summary>
[System.Serializable]
public class ChipSettingResource
{
    public int ConsumptionAmount { get; set; }

    public ChipSettingResource(int consumptionAmount)
    {
        this.ConsumptionAmount = consumptionAmount;
    }

    public ChipSettingResource(ChipSettingResource orgn) : this(orgn.ConsumptionAmount)
    {

    }
}
