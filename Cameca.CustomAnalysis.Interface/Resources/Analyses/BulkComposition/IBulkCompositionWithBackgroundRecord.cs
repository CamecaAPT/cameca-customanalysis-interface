namespace Cameca.CustomAnalysis.Interface;

public interface IBulkCompositionWithBackgroundRecord : IBulkCompositionRecord
{
	double BackgroundCount { get; }
	IBulkCompositionValues BackgroundValues { get; }
}
