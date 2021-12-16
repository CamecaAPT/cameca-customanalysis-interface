using System.Collections.Generic;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface.View
{
	public record ColorMap(IEnumerable<ColorStop> ColorStops)
	{
		public Color Bottom { get; set; }
		public Color NanColor { get; set; }
		public Color OutOfRangeBottom { get; set; }
		public Color OutOfRangeTop { get; set; }
		public Color Top { get; set; }
	}
}
