using UnityEngine;

public abstract class EventReceiverSO : ScriptableObject
{
    public abstract void OnEventReceive(GameEnums.Timing evnt, int[] eventsCount);

    public abstract int ArrayLength { get; }
}
