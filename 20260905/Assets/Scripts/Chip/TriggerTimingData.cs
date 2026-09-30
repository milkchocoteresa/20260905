using System;

public class TriggerTimingData
{
    private int _threshold; // Œ»Ý‚Ì”­‰Î‰ñ”
    private int _availableActivationTimesCount; // Žc‚è‚Ì”­“®‰Â”\‰ñ”
    public int ThresholdCount
    {
        get => _threshold;
        set => _threshold = Math.Max(0, value);
    }
    public int AvailableActivationTimesCount
    {
        get => _availableActivationTimesCount;
        set => _availableActivationTimesCount = Math.Max(0, value);
    }

    public TriggerTimingData(int threshold, int availableActivationTimesCount)
    {
        _threshold = threshold;
        _availableActivationTimesCount = availableActivationTimesCount;
    }
}
