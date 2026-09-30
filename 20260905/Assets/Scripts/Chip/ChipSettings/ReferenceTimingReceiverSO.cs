using UnityEngine;

public abstract class ReferenceTimingReceiverSO : ScriptableObject
{
    public abstract void ReferenceTimingReceive(TriggerContext context, int[] eventsCount);

    public abstract int ArrayLength { get; }
}
