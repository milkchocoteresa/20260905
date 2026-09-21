using UnityEngine;
/// <summary>
/// チップの効果が発動するときの参照
/// </summary>
[System.Serializable]
public class ChipSettingReference
{
    [SerializeField] private GameEnums.Reference _reference;
    public GameEnums.Reference Reference => _reference;

    public ChipSettingReference(GameEnums.Reference reference)
    {
        this._reference = reference;
    }

    public ChipSettingReference(ChipSettingReference orng) : this(orng.Reference)
    {

    }
}
