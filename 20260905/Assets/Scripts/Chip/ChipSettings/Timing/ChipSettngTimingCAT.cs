using System.Collections.Generic;
using UnityEngine;

public class ChipSettngTimingCAT : ChipSettingTiming
{
    [SerializeField] private List<Vector2Int> _positions;

    public List<Vector2Int> Positions => _positions;
}
