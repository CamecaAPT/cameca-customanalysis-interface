using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IRasterRenderData : IRenderData
{
	Color? HighlightColor { get; set; }
	bool IsGrayScale { get; set; }
	float Opacity { get; set; }
	RasterRenderDataInterpolationType InterpolationType { get; set; }
}
