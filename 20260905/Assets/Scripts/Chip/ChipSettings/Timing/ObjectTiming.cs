public class ObjectTiming // (‰¼)
{
    // primitive‚©–³ˆó‚Ì‚Ç‚¿‚ç‚©‚ğ‚Â
    public ObjectTiming CoreTiming { get; private set; }
    public ObjectTiming ONTiming { get; private set; }
    public ObjectTiming OFFTiming { get; private set; }

    public GameEnums.Timing PrimitiveCoreTiming { get; private set; }
    public GameEnums.Timing PrimitiveONTiming { get; private set; }
    public GameEnums.Timing PrimitiveOFFTiming { get; private set; }
}
