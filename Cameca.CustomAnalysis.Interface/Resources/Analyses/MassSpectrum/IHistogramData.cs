using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IHistogramData
{
	int BinCount { get; }
	double BinWidth { get; }
	double BinCenter { get; }
	long TotalCount { get; }
	ReadOnlyMemory<float> Values { get; }
}
