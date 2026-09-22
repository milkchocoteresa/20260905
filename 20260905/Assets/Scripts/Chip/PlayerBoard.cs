using UnityEngine;

public class PlayerBoard : Board
{
    private Inventory _inventory;

    public PlayerBoard(Vector2Int Size, Inventory inventory) : base(Size)
    {
        _inventory = inventory;
    }

    public override bool RegisterChip(Vector2Int pos, Chip chip)
    {
        Chip removed = RemoveChip(pos);
        _inventory.RegisterChip(removed);

        bool result = AddChip(pos, chip);
        // 取り除いたチップと組み込んだチップをChipGraphに報告
        return result;
    }

    public override Chip UnregisterChip(Vector2Int pos)
    {
        Chip removed = RemoveChip(pos);
        // 取り除いたチップをChipGraphに報告
        _inventory.RegisterChip(removed);
        return removed;
    }
}
