using UnityEngine;

public class EnemyBoard : Board
{
    public override bool RegisterChip(Vector2Int pos, Chip chip) // ‚à‚Æ‚à‚Æ‚ ‚Á‚½chip‚ğ—‚Æ‚·İ’è
    {
        RemoveChip(pos);
        return AddChip(pos, chip);
    }

    public override Chip UnregisterChip(Vector2Int pos)
    {
        return RemoveChip(pos);
    }
}
