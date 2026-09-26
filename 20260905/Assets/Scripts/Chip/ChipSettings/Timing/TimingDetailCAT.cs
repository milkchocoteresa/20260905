using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// チップの離散的発動タイミングのChipActionTrigger版
/// </summary>
[System.Serializable]
public class TimingDetailCAT : TimingDetail
{
    [SerializeField] private List<Vector2Int> _chipPositions; // トリガーとなるチップの場所
    public IReadOnlyList<Vector2Int> ChipPositions => _chipPositions;

    public TimingDetailCAT()
    {

    }
}
