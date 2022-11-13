using System;
using System.Numerics;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface ISelector2dRenderData : IRenderData
{
	/// <summary>Gets or sets the widget depth factor.</summary>
	public float Depth { get; set; }

	/// <summary>Gets left-bottom point X coordinate.</summary>
	public float Left { get; set; }

	/// <summary>Gets left-bottom point Y coordinate.</summary>
	public float Bottom { get; set; }

	/// <summary>Gets right-top point X coordinate.</summary>
	public float Right { get; set; }

	/// <summary>Gets right-top point Y coordinate.</summary>
	public float Top { get; set; }

	/// <summary>Gets or sets the widget controller color.</summary>
	public Color ControllersColor { get; set; }

	/// <summary>Gets or sets the widget controller color.</summary>
	public int ControllersSize { get; set; }

	/// <summary>Gets or sets the widget ellipse outline thickness.</summary>
	public float EllipseOutlineThickness { get; set; }

	/// <summary>Gets or sets the ellipse outline visibility flag.</summary>
	public bool EllipseOutlineVisible { get; set; }

	/// <summary>Gets or sets the widget ellipse outline color.</summary>
	public Color EllipseOutlineColor { get; set; }

	/// <summary>Gets or sets the widget rectangle outline thickness.</summary>
	public float RectOutlineThickness { get; set; }

	/// <summary>Gets or sets the widget rectangle outline color.</summary>
	public Color RectOutlineColor { get; set; }

	/// <summary>Gets or sets the widget min border.</summary>
	public Vector2 MinBound { get; set; }

	/// <summary>Gets or sets the widget max border.</summary>
	public Vector2 MaxBound { get; set; }
}
