using System.Collections.Generic;
using UnityEngine;

public abstract class TriggerTimingReceiverSO : ScriptableObject
{
    // outputの書き換えによって結果を伝える
    public void TriggerTimingReceive(TriggerTimingData ttData, TriggerContext context, int[] eventsCount, List<ChipActionResult> output)
    {
        ttData.ThresholdCount++;
        if (ttData.ThresholdCount < Threshold || ttData.AvailableActivationTimesCount == 0)
        {
            return;
        }
        else
        {
            Calculate(context, eventsCount, output);
        }
    }

    protected abstract void Calculate(TriggerContext context, int[] eventsCount, List<ChipActionResult> output);

    [SerializeField] public readonly int Threshold; // 発動までに必要な残りの発火回数
    [SerializeField] public readonly int TimeToActivation; // 発動までにかかる時間
    [SerializeField] public readonly int AvailableActivationTimes; // 残りの発動可能回数
}
