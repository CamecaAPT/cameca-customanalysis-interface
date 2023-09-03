using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IPeakDecompositionInputIon
{
	IonFormula Formula { get; }
	IEnumerable<int> ChargeStates { get; }
}
