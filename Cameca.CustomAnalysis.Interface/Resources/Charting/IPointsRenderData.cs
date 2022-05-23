using System;
using System.Numerics;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IPointsRenderData : IRenderData
{
	Color Color { get; set; }
	ReadOnlyMemory<Vector3> Positions { get; set; }
}
