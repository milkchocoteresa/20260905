using System.Collections.Generic;

public class Inventory
{
    public const int InvSize = 20;
    private List<Chip> _chips = new List<Chip>();

    public IReadOnlyList<Chip> Chips => _chips;

    /// <summary>
    /// チップをインベントリに入れる
    /// </summary>
    public void RegisterChip(Chip chip)
    {
        if (_chips.Count == 20)
        {
            // もともとあったチップを地面にはじき出す処理を追加
        }
        else
        {
            _chips.Add(chip);
            // _chipの順番を整理する処理を追加
        }
    }

    /// <summary>
    /// チップをインベントリから削除する
    /// </summary>
    public void UnregisterChip(Chip chip)
    {
        _chips.Remove(chip);
    }
}
