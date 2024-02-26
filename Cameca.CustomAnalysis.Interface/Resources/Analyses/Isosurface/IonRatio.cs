using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public class IonRatio
{
	public IReadOnlyCollection<IonFormula> IonNumerators { get; }
	public IReadOnlyCollection<IonFormula> IonDenominators { get; }

	public IonRatio(IReadOnlyCollection<IonFormula> numerators, IReadOnlyCollection<IonFormula> denominators)
	{
		IonNumerators = numerators;
		IonDenominators = denominators;
	}
}
