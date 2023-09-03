namespace Cameca.CustomAnalysis.Interface;

public interface IPeakDecompositionParameters
{
	PeakDecompositionBackgroundModel BackgroundModel { get; }
	/// <summary>
	/// The default range of mass-to-charge values in Da that lies below the low-value edge of the auto-generated range that is used in the calculation of background;
	/// applies only when the Local Background Model applied is Power Law.
	/// </summary>
	double SidebandWidth { get; }
	/// <summary>
	/// Max number of isotopes to use for complex ions
	/// </summary>
	int ComplexMaxIsotopesCount { get; }
	double MinIsotopeAbundance { get; }
	double LowerBoundMargin { get; }
	double UpperBoundMargin { get; }
	bool UseScaleRange { get; }
	double RangePowerScale { get; }
	double RangeScaling { get; }
	double StandardDeviationThreshold { get; }
	double AbundanceDifferenceThreshold { get; }

}
