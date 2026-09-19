/// <summary>
/// チップの効果が発動するときに消費するエフェクト
/// </summary>
[System.Serializable]
public class ChipSettingResourceEffect : ChipSettingResource
{
    public Chip.Effect effect;

    public ChipSettingResourceEffect(Chip.Effect effect, int consumptionAmount) : base(consumptionAmount)
    {
        this.effect = effect;
    }
}
