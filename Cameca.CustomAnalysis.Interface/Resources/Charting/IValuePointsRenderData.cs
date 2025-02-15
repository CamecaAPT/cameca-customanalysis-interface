using System;
using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public interface IValuePointsRenderData : IRenderData
{
	IColorMap? ColorMap { get; set; }
	ReadOnlyMemory<Vector4> PositionsWithValues { get; set; }
}
