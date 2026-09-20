/// <summary>
/// チップの効果が発動するときに消費するエフェクト
/// </summary>
[System.Serializable]
public class ChipSettingResourceEffect : ChipSettingResource
{
    public GameEnums.Effect Effect { get; set; }

    public ChipSettingResourceEffect(GameEnums.Effect effect, int consumptionAmount) : base(consumptionAmount)
    {
        this.Effect = effect;
    }

    public ChipSettingResourceEffect(ChipSettingResourceEffect orgn) : this(orgn.Effect, orgn.ConsumptionAmount)
    {

    }
}
