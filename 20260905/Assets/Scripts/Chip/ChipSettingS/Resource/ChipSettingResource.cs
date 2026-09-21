using UnityEngine;
/// <summary>
/// チップの効果が発動するときに消費するリソース
/// </summary>
[System.Serializable]
public class ChipSettingResource
{
    [SerializeField] private GameEnums.Resource _resource;
    [SerializeField] private int _consumptionAmount;
    public GameEnums.Resource Resource => _resource;
    public int ConsumptionAmount => _consumptionAmount;

    public ChipSettingResource(GameEnums.Resource resource, int consumptionAmount)
    {
        this._resource = resource;
        this._consumptionAmount = consumptionAmount;
    }

    public ChipSettingResource(ChipSettingResource orgn) : this(orgn.Resource, orgn.ConsumptionAmount)
    {

    }
}
