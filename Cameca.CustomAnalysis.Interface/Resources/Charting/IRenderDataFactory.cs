namespace Cameca.CustomAnalysis.Interface;

public interface IRenderDataFactory
{
    IPointsRenderData CreatePoints();
    ISpheresRenderData CreateSpheres();
    ISurfaceRenderData CreateSurface();
    ILineRenderData CreateLine();
    IHistogramRenderData CreateHistogram();
    IHistogram2DRenderData CreateHistogram2D();
}
