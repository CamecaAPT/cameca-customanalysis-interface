using System;

namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// A fixed width histogram of floating point values.
/// Histogram is defined by a starting value and a fixed bin step.
/// Values are contiguous.
/// Total histogram range is [Start, Start + BinWidth * Values.Length].
/// </summary>
public interface IHistogramData
{
	double Start { get; }
	double BinWidth { get; }
	ReadOnlyMemory<float> Values { get; }
}
