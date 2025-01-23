using System;
using System.Numerics;
using System.Windows.Media;


namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Display error bars
/// </summary>
public interface IErrorRenderData : IRenderData
{
	/// <summary>Error bar colors</summary>
	Color Color { get; set; }
	/// <summary>
	/// Error stripe area tranparency alpha if using <see cref="ErrorDisplayType.Stripes"/>
	/// </summary>
	/// <remarks>
	/// Value between 0 and 1, 0 is fully transparent and 1 is fully opaque.
	/// </remarks>
	float Alpha { get; set; }
	/// <summary>
	/// Vector defining axis of error offsets
	/// </summary>
	/// <remarks>
	/// Generally only necessary if changing the chart projection.
	/// </remarks>
	Vector3 OffsetDirection { get; set; }
	/// <summary>Positions and error offsets</summary>
	ReadOnlyMemory<ErrorDataPoint>? Data { get; set; }
	/// <summary>Set error display type</summary>
	ErrorDisplayType DisplayType { get; set; }
	/// <summary>Line thickness</summary>
	float LineThickness { get; set; }
	/// <summary>Width of error bar dash if using <see cref="ErrorDisplayType.Bars"/></summary>
	int DashWidth { get; set; }

}
