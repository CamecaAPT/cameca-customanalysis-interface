namespace Cameca.CustomAnalysis.Interface.Resources.Charting;

public interface IColorMapFactory
{
	IColorMap CreateColorMap();
	IColorStop AddColorStop(IColorMap colorMap);
}
