namespace Cameca.CustomAnalysis.Interface;

public interface IMassSpectrumData
{
	IHistogramData MassHistogram { get; set; }
	IHistogramData BackgroundModel { get; set; }
}
