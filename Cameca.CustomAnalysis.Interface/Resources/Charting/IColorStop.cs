using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IColorStop
{
	Color BottomColor { get; }
	float RelativePosition { get; }
	Color TopColor { get; }
}
