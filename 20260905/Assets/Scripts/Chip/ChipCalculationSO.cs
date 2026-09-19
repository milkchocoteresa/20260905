using System.Collections.Generic;
using UnityEngine;

public abstract class ChipCalculationSO : ScriptableObject
{
    public abstract void Calculate(ChipExecutionContext cec, List<ChipActionResult> output);
}
