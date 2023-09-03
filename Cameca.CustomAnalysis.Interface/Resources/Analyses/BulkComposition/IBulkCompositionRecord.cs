namespace Cameca.CustomAnalysis.Interface;

public interface IBulkCompositionRecord
{
	IonFormula Formula { get; }
	IBulkCompositionValues Values { get; }
}
