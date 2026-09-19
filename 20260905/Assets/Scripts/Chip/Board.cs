using UnityEngine;

public abstract class Board
{
    public Board(Vector2Int size)
    {
        _chips = new Chip[size.x, size.y];
    }

    protected Chip[,] _chips;

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

    // ボードの効果をあらかじめツリーにしておく
}
