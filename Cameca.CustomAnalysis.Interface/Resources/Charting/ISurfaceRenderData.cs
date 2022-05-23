using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface ISurfaceRenderData : IRenderData
{
	IndexedTriangleArray SurfaceIndexedTriangleArray { get; set; }
	Color Color { get; set; }
}
