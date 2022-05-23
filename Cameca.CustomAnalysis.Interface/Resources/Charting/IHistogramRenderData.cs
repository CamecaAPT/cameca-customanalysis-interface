using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IHistogramRenderData : IRenderData
{
	float? CustomMinForLog { get; set; }
	float Thickness { get; set; }
	int CustomStep { get; set; }
	Color Color { get; set; }
	AveragingType AggregationType { get; set; }
	IReadOnlyList<IChart2DSlice> VerticalSlices { get; set; }
	ReadOnlyMemory<Vector2> Values { get; set; }
}
