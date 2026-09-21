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
        _inventory.UnregisterChip(removeChip(pos));
        bool result = addChip(pos, chip);

        return result;
    }

    public override Chip UnregisterChip(Vector2Int pos)
    {
        Chip chip = removeChip(pos);
        _inventory.RegisterChip(chip);
        return chip;
    }
}
