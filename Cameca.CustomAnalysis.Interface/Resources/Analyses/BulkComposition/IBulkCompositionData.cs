namespace Cameca.CustomAnalysis.Interface;

public interface IBulkCompositionData
{
	IBulkCompositionWithBackgroundRecord[] Ionic { get; }
	IBulkCompositionWithBackgroundRecord[] Decomposed { get; }
}
