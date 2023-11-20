namespace Cameca.CustomAnalysis.Interface;

public interface IMassSpectrumParameters
{
	double BinWidth { get; }
	double? UpperLimit { get; }
	bool TruncateCorrectedValues { get; }
}
