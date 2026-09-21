using UnityEngine;
/// <summary>
/// チップの効果が発動するときに消費するエフェクト
/// </summary>
[System.Serializable]
public class ChipSettingResourceEffect : ChipSettingResource
{
    [SerializeField] private GameEnums.Effect _effect;
    public GameEnums.Effect Effect => _effect;

    public ChipSettingResourceEffect(GameEnums.Resource resource, GameEnums.Effect effect, int consumptionAmount) : base(resource, consumptionAmount)
    {
        this._effect = effect;
    }

    public ChipSettingResourceEffect(ChipSettingResourceEffect orgn) : this(orgn.Resource, orgn.Effect, orgn.ConsumptionAmount)
    {

    }
}
