using System;
using System.Numerics;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface ISelector2DRenderData : IRenderData
{
	/// <summary>Gets or sets the widget minimum corner point</summary>
	public Vector3 MinPoint { get; set; }

	/// <summary>Gets or sets the widget maximum corner point</summary>
	public Vector3 MaxPoint { get; set; }

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

	/// <summary>Gets or sets the widget min allowed corner.</summary>
	public Vector3 MinBoundsCorner { get; set; }

	/// <summary>Gets or sets the widget max allowed corner.</summary>
	public Vector3 MaxBoundsCorner { get; set; }
}
