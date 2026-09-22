using System.Collections.Generic;
using UnityEngine;

public abstract class Board
{
    protected Chip[,] _chips;

    public Board(Vector2Int size)
    {
        _chips = new Chip[size.x, size.y];
    }

    /// <summary>
    /// ソケットの場所と組み込むチップを受け取り、成功したかをbool値を返す。
    /// </summary>
    protected bool AddChip(Vector2Int pos, Chip chip)
    {
        if (chip == null || _chips[pos.x, pos.y] != null)
        {
            return false;
        }
        else
        {
            _chips[pos.x, pos.y] = chip;
            return true;
        }
    }

    /// <summary>
    /// チップを取り除くソケットの場所を受け取り、取り除いたチップを返す。
    /// </summary>
    protected Chip RemoveChip(Vector2Int pos)
    {
        Chip removed;
        if ((removed = _chips[pos.x, pos.y]) == null)
        {
            return null;
        }
        else
        {
            _chips[pos.x, pos.y] = null;
            return removed;
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
            list.Add(_chips[pos.x, pos.y]);
        }
        return list;
    }
}
