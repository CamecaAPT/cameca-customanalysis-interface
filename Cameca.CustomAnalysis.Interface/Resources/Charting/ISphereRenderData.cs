namespace Cameca.CustomAnalysis.Interface;

public interface ISpheresRenderData : IPointsRenderData
{
	int Resolution { get; set; }
	float Radius { get; set; }
}
