public class ChipActionResult
{
    public readonly Chip Chip; // 実行時にThresholdを0にしてとAvailableActivationTimesCountを-1するため
    // 使うリソース/効果/効果を与えた相手/

    public ChipActionResult(Chip chip)
    {
        Chip = chip;
    }
}
