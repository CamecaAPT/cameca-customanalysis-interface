using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonFormulaIsotopeCalculator
{
	/// <summary>
	/// Returns list of complex isotopes for a formula.
	/// </summary>
	/// <remarks>
	///	Compute all mass and abundances for A_nB_m... where A,B,... are elements; n,m... are
	///	their respective numbers in the complex. Furthermore, Each element has A_i, B_i... isotopes.
	///
	///  The calculation takes two steps:  First compute the the isotope abundances and masses for the
	///  sub-complexes: A_n, B_m, etc.  Once the sub-complex isotope abundances and masses are computed,
	///  these get combined to form the actual complex isotope masses and abundances.
	///
	///  After each step, the degenerate isotopes are combined.  Two isotopes (complex or subcomplex)
	///  are degenerate if they have the same Atomic Mass number (A) - in principle they will have different
	///  masses, but this is well beyond the resolving power of an atom probe.
	/// </remarks>
	/// <param name="ionFormula"></param>
	/// <param name="options"></param>
	/// <returns></returns>
	IEnumerable<IIsotope> GetIsotopes(IonFormula ionFormula, IonFormulaIsotopeOptions? options = null);
}
