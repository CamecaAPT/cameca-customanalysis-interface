namespace Cameca.CustomAnalysis.Interface;

public interface IMassSpectrumData
{
	IHistogramData MassHistogram { get; }
	IHistogramData BackgroundModel { get; }
}
