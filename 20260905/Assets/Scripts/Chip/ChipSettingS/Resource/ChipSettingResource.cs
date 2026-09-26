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

    public ChipSettingResource()
    {

    }
}
