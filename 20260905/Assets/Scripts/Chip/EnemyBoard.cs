using UnityEngine;

public class EnemyBoard : Board
{
    public EnemyBoard(Vector2Int size) : base(size)
    {
    }

    public override bool RegisterChip(Vector2Int pos, Chip chip) // ‚à‚Æ‚à‚Æ‚ ‚Á‚½chip‚ğ—‚Æ‚·İ’è
    {
        removeChip(pos);
        return addChip(pos, chip);
    }

    public override Chip UnregisterChip(Vector2Int pos)
    {
        return removeChip(pos);
    }
}
