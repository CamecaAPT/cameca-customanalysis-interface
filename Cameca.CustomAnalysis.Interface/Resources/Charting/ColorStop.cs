using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public sealed class ColorStop
{
	public Color BottomColor { get; }
	public float RelativePosition { get; }
	public Color TopColor { get; }

	public ColorStop(float relativePosition, Color color)
	{
		RelativePosition = relativePosition;
		BottomColor = color;
		TopColor = color;
	}

	public ColorStop(float relativePosition, Color bottomColor, Color topColor)
	{
		RelativePosition = relativePosition;
		BottomColor = bottomColor;
		TopColor = topColor;
	}
}
