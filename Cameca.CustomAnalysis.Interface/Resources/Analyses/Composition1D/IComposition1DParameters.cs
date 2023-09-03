namespace Cameca.CustomAnalysis.Interface;

public interface IComposition1DParameters
{
	Composition1DMode Mode { get; }
	Composition1DDirection Direction { get; }
	double BinWidth { get; }
	int IonsPerSample { get; }
	int IonsPerStep { get; }
}
