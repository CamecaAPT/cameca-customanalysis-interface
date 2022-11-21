using System;

namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Defines what transformation controllers are included in the selector widget.
/// </summary>
[Flags]
public enum SelectionWidgetController
{
	/// <summary>No controllers.</summary>
	None = 0,
	/// <summary>Controller at center point to set translation.</summary>
	Translate = 1 << 0,
	/// <summary>Controller at vertices to set size along all axes.</summary>
	SizeVertex = 1 << 1,
	/// <summary>Controller at edges to set size along edge-orthogonal axes.</summary>
	SizeEdge = 1 << 2,
	/// <summary>Include all controllers.</summary>
	All = Translate | SizeVertex | SizeEdge,
}
