using System.Collections.Generic;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IColorMap
{
	public Color Bottom { get; }
	public Color NanColor { get; }
	public Color OutOfRangeBottom { get; }
	public Color OutOfRangeTop { get; }
	public Color Top { get; }
	public IReadOnlyList<IColorStop> ColorStops { get; }
}
