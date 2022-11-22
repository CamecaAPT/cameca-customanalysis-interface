using System.Numerics;
using CommunityToolkit.HighPerformance;

namespace Cameca.CustomAnalysis.Interface;

public interface IHistogram2DRenderData : IRasterRenderData
{
	IColorMap? ColorMap { get; set; }
	Vector2 Min { get; }
	Vector2 Max { get; }
	double Height { get; set; }
	double Width { get; set; }
	void Update(ReadOnlyMemory2D<float> values, Vector2 binSize, Vector2 origin = default);
	// ReSharper disable once MethodOverloadWithOptionalParameter
	// Optional parameters overload is acceptable for backwards compatibility. Implementations will call same method
	void Update(ReadOnlyMemory2D<float> values, Vector2 binSize, Vector2 origin = default, float? minValue = null, float? maxValue = null);
}
