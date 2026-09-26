using UnityEngine;

[CreateAssetMenu(menuName = "Chips/ChipSetting")]
public class ChipSettingSO : ScriptableObject
{
    [SerializeField] private GameEnums.Role _type;
    [SerializeField] private GameEnums.Availability _availability;
    [SerializeField] private GameEnums.Mobility _mobility;

    // !!!注意!!! 引数ありのコンストラクタのみがある状態だと[SerializeReference, SubclassSelector]が使えません。 
    [SerializeReference, SubclassSelector] private ChipSettingCondition _condition;

    [SerializeField] private ChipSettingRule _chipRule;

    // 見た目のスプライト追加

    public GameEnums.Role Type => _type;
    public GameEnums.Availability Availability => _availability;
    public GameEnums.Mobility Mobility => _mobility;

    public ChipSettingCondition Condition => _condition;
    public ChipSettingRule ChipRule => _chipRule;
}
