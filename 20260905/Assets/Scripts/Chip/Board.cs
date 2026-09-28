using System.Collections.Generic;
using UnityEngine;

public abstract class Board
{
    protected Dictionary<Vector2Int, Chip> _chips = new Dictionary<Vector2Int, Chip>();

    /// <summary>
    /// ソケットの場所と組み込むチップを受け取り、成功したかをbool値を返す。
    /// </summary>
    protected bool AddChip(Vector2Int pos, Chip chip)
    {
        if (chip == null || _chips.ContainsKey(pos))
        {
            return false;
        }
        else
        {
            _chips.Add(pos, chip);
            return true;
        }
    }

    /// <summary>
    /// チップを取り除くソケットの場所を受け取り、取り除いたチップを返す。
    /// </summary>
    protected Chip RemoveChip(Vector2Int pos)
    {
        if (_chips.TryGetValue(pos, out Chip removed))
        {
            _chips.Remove(pos);
            return removed;
        }
        else
        {
            return null;
        }
    }


    /// <summary>
    /// チップの登録をする。ChipGraphに登録したチップ
    /// </summary>
    public abstract bool RegisterChip(Vector2Int pos, Chip chip);

    public abstract Chip UnregisterChip(Vector2Int pos);

    public List<Chip> GetChipFromPos(List<Vector2Int> positions)
    {
        List<Chip> list = new List<Chip>();
        foreach (Vector2Int pos in positions)
        {
            _chips.TryGetValue(pos, out Chip chip);
            list.Add(chip);
        }
        return list;
    }
}
