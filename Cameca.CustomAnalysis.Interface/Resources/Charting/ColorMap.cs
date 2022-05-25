using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public sealed class ColorMap
{
	public static readonly Color DefaultBottom = Colors.Blue;
	public static readonly Color DefaultNanColor = Colors.Cyan;
	public static readonly Color DefaultOutOfRangeBottom = Colors.Purple;
	public static readonly Color DefaultOutOfRangeTop = Colors.DeepPink;
	public static readonly Color DefaultTop = Colors.Red;

	public Color Bottom { get; init; } = DefaultBottom;

	public Color NanColor { get; init; } = DefaultNanColor;

	public Color OutOfRangeBottom { get; init; } = DefaultOutOfRangeBottom;

	public Color OutOfRangeTop { get; init; } = DefaultOutOfRangeTop;

	public Color Top { get; init; } = DefaultTop;

	public IReadOnlyList<ColorStop> ColorStops { get; init; } = Enumerable.Empty<ColorStop>().ToList();
}
