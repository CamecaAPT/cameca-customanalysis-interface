namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Filtering options for calculating complex formula isotopes.
/// </summary>
/// <remarks>
/// First removes isotopes with abundance less than <see cref="MinimumIsotopeAbundance"/>,
/// the filters to a maximum of <see cref="MaxIsotopeCount"/> isotopes if specified.
/// </remarks>
public class IonFormulaIsotopeOptions
{
	/// <summary>
	/// Limit to a maximum number of this many isotopes.
	/// </summary>
	public int? MaxIsotopeCount { get; init; } = null;

	/// <summary>
	/// Remove itotopes with minimum abundance less than this value.
	/// </summary>
	public double MinimumIsotopeAbundance { get; init; } = 0d;

	/// <summary>
	/// Id of the element data set to use for isotope information for the calculation.
	/// If null, the application default element data set will be used.
	/// </summary>
	/// <remarks>
	/// See <see cref="INodeElementDataSet.ElementDataSetId"/> for retrieving the current element data set,
	/// or <see cref="IElementDataSetService"/> for retrieving specific element data sets.
	/// </remarks>
	public int? ElementDataSetId { get; init; } = null;

	/// <summary>
	/// Normaize remaining isotope abundances after any filtering to sum to 1.
	/// </summary>
	public bool NormalizeAbundances { get; set; } = true;
}
