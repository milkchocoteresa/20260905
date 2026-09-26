using UnityEngine;
/// <summary>
/// チップの効果が発動するときに消費するエフェクト
/// </summary>
[System.Serializable]
public class ChipSettingResourceEffect : ChipSettingResource
{
    [SerializeField] private GameEnums.Effect _effect;
    public GameEnums.Effect Effect => _effect;

    public ChipSettingResourceEffect()
    {

    }
}
