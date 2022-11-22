using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IMassSpectrumRangeManager
{
	bool IsEditable { get; }
	IDictionary<IonFormula, IonRangeDefinition> GetRanges();
	Task<bool> SetRanges(IDictionary<IonFormula, IonRangeDefinition> ranges);
}
