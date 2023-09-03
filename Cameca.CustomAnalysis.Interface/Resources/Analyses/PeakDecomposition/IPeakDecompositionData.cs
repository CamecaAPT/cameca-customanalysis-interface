namespace Cameca.CustomAnalysis.Interface;

public interface IPeakDecompositionData
{
	IonFormula Formula { get; }
	int Charge { get; }
	double Mass { get; }
	double Low { get; }
	double Upper { get; }
	int UncorrectedCounts { get; }
	int BackgroundCorrectedCounts { get; }
	int DecomposedCounts { get; }
	double DecompositionAbundance { get; }
	double ExpectedAbundance { get; }
	double EstimatedError { get; }
	double StandardDeviation { get; }
}
