using System;
using System.Numerics;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Displays a line with data point markers
/// </summary>
public interface ISeriesRenderData : IRenderData
{
	/// <summary>Line color</summary>
	Color Color { get; set; }
	/// <summary>Line thickness</summary>
	float Thickness { get; set; }
	/// <summary>Data points</summary>
	ReadOnlyMemory<Vector3>? Positions { get; set; }
	/// <summary>Line display style</summary>
	LineStyle LineStyle { get; set; }
	/// <summary>Marker shape</summary>
	MarkerShape MarkerShape { get; set; }
	/// <summary>Marker color</summary>
	Color MarkerColor { get; set; }
	/// <summary>Marker size</summary>
	int MarkerSize { get; set; }

}
