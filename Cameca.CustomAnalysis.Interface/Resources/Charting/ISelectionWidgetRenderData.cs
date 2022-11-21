using System.Numerics;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface ISelectionWidgetRenderData : IRenderData
{
	/// <summary>Gets or sets the widget line thickness.</summary>
	public float LineThickness { get; set; }

	/// <summary>Gets or sets the widget line color.</summary>
	public Color LineColor { get; set; }

	/// <summary>Gets or sets the widget controller size.</summary>
	public float ControllersSize { get; set; }

	/// <summary>Gets or sets the widget controller color.</summary>
	public Color ControllersColor { get; set; }

	/// <summary>Gets or sets the widget center point, defining the widget translation from origin.</summary>
	public Vector3 Translation { get; set; }

	/// <summary>Gets or sets the widget scaling, defining size of widget along all axes.</summary>
	public Vector3 Scaling { get; set; }

	/// <summary>Gets or sets the controllers used by the selector widget.</summary>
	public SelectionWidgetController Controllers { get; set; }
}
