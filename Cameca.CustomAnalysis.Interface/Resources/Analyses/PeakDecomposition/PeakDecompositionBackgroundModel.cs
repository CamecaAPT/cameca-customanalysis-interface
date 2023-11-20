namespace Cameca.CustomAnalysis.Interface;

public enum PeakDecompositionBackgroundModel
{
	/// <summary>
	/// Use TOF-independent model.
	/// </summary>
	No = 0,
	/// <summary>
	/// Use the lower sideband to compute average background level.
	/// </summary>
	Constant,
	/// <summary>
	/// Fit lower sideband to A/(m-m0)**b where A and b are fit
	/// and m0 is the center of the range just below the sideband.
	/// </summary>
	PowerLaw,
}
