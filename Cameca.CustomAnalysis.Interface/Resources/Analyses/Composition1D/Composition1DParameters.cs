namespace Cameca.CustomAnalysis.Interface;

public sealed class Composition1DParameters : IComposition1DParameters
{
	public const Composition1DMode DefaultMode = Composition1DMode.FixedBinWidth;
	public const Composition1DDirection DefaultDirection = Composition1DDirection.Z;
	public const float DefaultBinWidth = 0.1f;
	public const int DefaultIonsPerSample = 5000;
	public const int DefaultIonsPerStep = 5000;

	public Composition1DMode Mode { get; init; } = DefaultMode;

	public Composition1DDirection Direction { get; init; } = DefaultDirection;

	public double BinWidth { get; init; } = DefaultBinWidth;

	public int IonsPerSample { get; init; } = DefaultIonsPerSample;

	public int IonsPerStep { get; init; } = DefaultIonsPerStep;
}
