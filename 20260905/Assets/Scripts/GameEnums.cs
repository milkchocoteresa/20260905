public class GameEnums
{
    // 複数選択可能にしたい場合はusing Systemで[Flags]属性を付ける

    public enum Type
    {
        Predicate,
        Modifier
    }

    /// <summary>
    /// チップが有効か無効か
    /// <list type="bullet">
    ///   <item><term>Unavailable</term><description>無効</description></item>
    ///   <item><term>Available</term><description>有効</description></item>
    /// </list>
    /// </summary>
    public enum Availability // 有効か無効か
    {
        Unavailable,    // 無効
        Available,      // 有効
    }

    /// <summary>
    /// チップが移動可能かどうか
    /// <list type="bullet">
    ///   <item><term>Immovable</term><description>移動不可能</description></item>
    ///   <item><term>Movable</term><description>移動可能</description></item>
    /// </list>
    /// </summary>
    public enum Mobility // 移動可能かどうか
    {
        Immovable,      // 不可能
        Movable,        // 可能
    }

    /// <summary>
    /// 発動タイミング<br/>
    /// ===離散的タイミング===<br/>
    /// =====追加情報が不要なもの=====
    /// <list type="bullet">
    ///   <item><term>None</term><description>発動しない</description></item>
    ///   <item><term>Passive</term><description>常時</description></item>
    ///   <item><term>Hit</term><description>攻撃がヒットしたとき</description></item>
    ///   <item><term>TakeDamage</term><description>被ダメ時</description></item>
    ///   <item><term>FullResource</term><description>一定以上のリソースがチップに貯まったとき</description></item>
    ///   <item><term>OrbTrigger</term><description>オーブの効果が発動したとき</description></item>
    /// </list>
    /// =====追加情報が必要なもの=====
    /// <list type="bullet">
    ///   <item><term>ChipActionTrigger</term><description>指定した位置にあるチップに連動して</description></item>
    ///   <item><term>StaminaTrigger</term><description>スタミナの変化に連動して</description></item>
    ///   <item><term>HPTrigger</term><description>HPの変化に連動して</description></item>
    ///   
    /// ===連続的タイミング===
    ///   <item><term>RestrictedPassive</term><description>条件を満たしているとき常に</description></item>
    /// </list>
    /// </summary>
    public enum Timing // 発動タイミング
    {
        None,           // 発動しない

        // 離散的タイミング(発動に必要な回数 + 発動までの時間 + 発動可能回数)discrete
        // 追加情報が不要なもの
        Passive,        // 常時
        Hit,            // 攻撃ヒット時
        TakeDamage,     // 被ダメ時
        FullResource,   // 一定以上のリソースがチップに貯まったとき
        OrbTrigger,     // オーブの効果が発動したとき

        // 追加情報が必要なもの
        ChipActionTrigger,  // 指定した位置にあるチップに連動して(チップの位置を指定するためのVector2IntのList)
        StaminaTrigger,     // スタミナの変化に連動して(発動条件のスタミナ量の不等式 + 発動できる状態かどうかのbool値)
        HPTrigger,          // HPの変化に連動して(スタミナと同じ)


        // 連続的タイミングcontinuous
        RestrictedPassive,  // 条件を満たしているとき常に ONもOFFも上記の離散的タイミングを使用する。〇〇してからn秒間という形にしたい場合は発動までの秒数の数値で調節
    }

    /// <summary>
    /// 何を参照するか
    /// <list type="bullet">
    ///   <item><term>None</term><description>何も参照しない</description></item>
    ///   <item><term>Chip</term><description>指定した位置にあるチップ</description></item>
    ///   <item><term>Resource</term><description>リソース</description></item>
    ///   <item><term>Enemy</term><description>敵</description></item>
    /// </list>
    /// </summary>
    public enum Reference // 何を参照するか
    {
        None,           // 何も参照しない
        Chip,           // 指定した位置にあるチップ(種類)
        Resource,       // リソース(Resource)
        Enemy,          // 敵(数、HP)
    }

    /// <summary>
    /// 何を消費するか
    /// <list type="bullet">
    ///   <item><term>Stamina</term><description>スタミナ</description></item>
    ///   <item><term>MP</term><description>MP</description></item>
    ///   <item><term>HP</term><description>HP</description></item>
    ///   <item><term>Effect</term><description>エフェクト</description></item>
    /// </list>
    /// </summary>
    public enum Resource // 何を消費するか(消費量)
    {
        None,           // 消費しない
        Stamina,        // スタミナ
        MP,             // MP(MPタンクチップ)
        HP,             // HP
        Effect,         // エフェクト(エフェクトの種類)
    }

    /// <summary>
    /// エフェクト
    /// <list type="bullet">
    ///   <item><term>AttackUp</term><description>攻撃力上昇</description></item>
    ///   <item><term>AttackDown</term><description>攻撃力低下</description></item>
    ///   <item><term>Shield</term><description>シールド</description></item>
    ///   <item><term>Heal</term><description>回復</description></item>
    ///   <item><term>Poison</term><description>毒</description></item>
    ///   <item><term>CRITUp</term><description>クリティカル率上昇</description></item>
    ///   <item><term>ChipActionSpeedUp</term><description>チップ発動速度上昇</description></item>
    ///   <item><term>ChipActionSpeedDown</term><description>チップ発動速度低下</description></item>
    ///   <item><term>StaminaRecSpeedUp</term><description>スタミナ回復速度上昇</description></item>
    ///   <item><term>StaminaRecSpeedDown</term><description>スタミナ回復速度低下</description></item>
    ///   <item><term>MPGenSpeedUp</term><description>MP生産速度上昇</description></item>
    ///   <item><term>MPGenSpeedUp</term><description>MP生産速度低下</description></item>
    ///   <item><term>MovementSpeedUp</term><description>移動速度上昇</description></item>
    ///   <item><term>MovementSpeedDown</term><description>移動速度低下</description></item>
    ///   <item><term>OrbDropFrequencyUp</term><description>オーブのドロップ頻度増加</description></item>
    /// </list>
    /// </summary>
    public enum Effect // エフェクト
    {
        AttackUp,               // 攻撃力上昇
        AttackDown,             // 攻撃力低下
        Shield,                 // シールド
        Heal,                   // 回復
        Poison,                 // 毒
        CRITUp,                 // クリティカル率上昇
        ChipActionSpeedUp,      // チップ発動速度上昇
        ChipActionSpeedDown,    // チップ発動速度低下
        StaminaRecSpeedUp,      // スタミナ回復速度上昇
        StaminaRecSpeedDown,    // スタミナ回復速度低下
        MPGenSpeedUp,           // MP生産速度上昇
        MPGenSpeedDown,         // MP生産速度低下
        MovementSpeedUp,        // 移動速度上昇
        MovementSpeedDown,      // 移動速度低下
        OrbDropFrequencyUp,     // オーブのドロップ頻度増加
    }

    /// <summary>
    /// 効果を与える相手
    /// <list type="bullet">
    ///   <item><term>None</term><description>なし</description></item>
    ///   <item><term>Chip</term><description>指定した位置にあるチップ</description></item>
    ///   <item><term>Player</term><description>プレイヤー</description></item>
    ///   <item><term>NextHitEnemy</term><description>次に攻撃が当たった敵</description></item>
    ///   <item><term>OrbInArea</term><description>指定した範囲の中にあるオーブ</description></item>
    ///   <item><term>EnemyInArea</term><description>指定した範囲の中にいる敵</description></item>
    /// </list>
    /// </summary>
    public enum Target // 効果を与える相手
    {
        None,           // なし
        Chip,           // 指定した位置にあるチップ(チップの位置を指定するためのVector2IntのList)
        Player,         // プレイヤー

        NextHitEnemy,   // 次に攻撃が当たった敵

        OrbInArea,      // 指定した範囲の中にあるオーブ(範囲の中心と半径)
        EnemyInArea,    // 指定した範囲の中にいる敵(範囲の中心と半径)
    }
}
