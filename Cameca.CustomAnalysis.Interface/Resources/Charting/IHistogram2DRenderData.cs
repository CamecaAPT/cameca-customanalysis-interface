using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public interface IHistogram2DRenderData : IRasterRenderData
{
	IColorMap? ColorMap { get; set; }
	Vector2 Min { get; }
	Vector2 Max { get; }
	double Height { get; set; }
	double Width { get; set; }
	void Update(ReadOnlyMemoryND<float> values, Vector2 binSize, Vector2 origin = default);
}
