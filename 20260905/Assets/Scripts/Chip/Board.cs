using System.Collections.Generic;
using UnityEngine;

public abstract class Board
{
    protected Chip[,] _chips;

    public Board(Vector2Int size)
    {
        _chips = new Chip[size.x, size.y];
    }

    protected bool addChip(Vector2Int pos, Chip chip)
    {
        if (chip == null)
        {
            return false;
        }
        else if (_chips[pos.x, pos.y] != null)
        {
            return false;
        }
        else
        {
            _chips[pos.x, pos.y] = chip;
            return true;
        }
    }

    protected Chip removeChip(Vector2Int pos)
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
