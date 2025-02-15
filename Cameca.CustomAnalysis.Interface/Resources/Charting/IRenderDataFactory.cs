namespace Cameca.CustomAnalysis.Interface;

public interface IRenderDataFactory
{
	IPointsRenderData CreatePoints();
	IValuePointsRenderData CreateValuePoints();
	ISpheresRenderData CreateSpheres();
	ISurfaceRenderData CreateSurface();
	ILineRenderData CreateLine();
	IHistogramRenderData CreateHistogram();
	IHistogram2DRenderData CreateHistogram2D();
	ISelectionWidgetRenderData CreateSelectionWidget();
	ISeriesRenderData CreateSeries();
	IErrorRenderData CreateError();
}
