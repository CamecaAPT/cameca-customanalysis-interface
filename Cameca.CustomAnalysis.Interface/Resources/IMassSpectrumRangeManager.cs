using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IMassSpectrumRangeManager
{
	bool IsEditable { get; }
	[Obsolete("Use GetIonRanges instead: incorrectly handles multiple unknown ions and does not include Color")]
	IDictionary<IonFormula, IonRangeDefinition> GetRanges();
	[Obsolete("Use GetIonRanges instead: incorrectly handles multiple unknown ions")]
	Task<bool> SetRanges(IDictionary<IonFormula, IonRangeDefinition> ranges);
	[Obsolete("Use GetIonRanges instead: incorrectly handles multiple unknown ions")]
	bool SetRangesSync(IDictionary<IonFormula, IonRangeDefinition> ranges)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();

	IEnumerable<IonTypeInfoRange> GetIonRanges()
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();

	/// <summary>
	/// Sets ranges by replacing all ion ranges. Does not support changing Color.
	/// </summary>
	/// <param name="ionRanges"></param>
	/// <exception cref="ArgumentException">
	/// <paramref name="ionRanges"/> includes duplicate names that do not match formula or volume, or some ranges overlap
	/// </exception>
	/// <returns></returns>
	Task<bool> SetIonRanges(IEnumerable<IonTypeInfoRange> ionRanges)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();

	/// <inheritdoc cref="SetIonRanges(IEnumerable{IonTypeInfoRange})"/>
	bool SetIonRangesSync(IEnumerable<IonTypeInfoRange> ionRanges)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();

}
