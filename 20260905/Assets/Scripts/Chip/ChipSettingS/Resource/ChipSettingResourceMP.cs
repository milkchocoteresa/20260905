/// <summary>
/// チップの効果が発動するときに消費するMP
/// </summary>
[System.Serializable]
public class ChipSettingResourceMP : ChipSettingResource
{
    // どのMPタンクか

    public ChipSettingResourceMP(int consumptionAmount) : base(consumptionAmount)
    {
        // 参照じゃなくてコピー渡すように注意
    }

    public ChipSettingResourceMP(ChipSettingResourceMP orgn) : this(orgn.ConsumptionAmount)
    {

    }
}
