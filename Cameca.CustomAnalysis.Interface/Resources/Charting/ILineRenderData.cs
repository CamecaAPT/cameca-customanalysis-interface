using System;
using System.Numerics;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface ILineRenderData : IRenderData
{
	Color Color { get; set; }
	bool Strip { get; set; }
	float Thickness { get; set; }
	float? PickingThickness { get; set; }
	ReadOnlyMemory<Vector3>? Positions { get; set; }
}
