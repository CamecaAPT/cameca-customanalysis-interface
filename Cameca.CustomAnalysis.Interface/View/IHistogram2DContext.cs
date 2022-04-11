namespace Cameca.CustomAnalysis.Interface.View;

public interface IHistogram2DContext
{
    int XBins { get; }
    double XLowEdge { get; }
    double XBinWidth { get; }
    int YBins { get; }
    double YLowEdge { get; }
    double YBinWidth { get; }
    float? OverrideMin { get; }

    float GetBinValue(uint xBin, uint yBin);
}