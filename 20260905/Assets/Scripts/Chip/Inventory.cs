using System.Collections.Generic;

public class Inventory
{
    public const int InvSize = 20;
    private List<Chip> _chips = new List<Chip>();

    public IReadOnlyList<Chip> Chips => _chips;

    public bool RegisterChip(Chip chip)
    {
        if (_chips.Count == 20)
        {
            // chip‚ğ’n–Ê‚É“f‚«o‚·ˆ—‚ğ’Ç‰Á
            return false;
        }
        else
        {
            _chips.Add(chip);
            // _chip‚Ì‡”Ô‚ğ®—‚·‚éˆ—‚ğ’Ç‰Á
            return true;
        }
    }

    public bool UnregisterChip(Chip chip)
    {
        if (!_chips.Contains(chip))
        {
            return false;
        }
        else
        {
            _chips.Remove(chip);
            return true;
        }
    }
}
