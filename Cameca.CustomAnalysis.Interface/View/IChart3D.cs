using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface.View;

/// <summary>
/// Simple 3d chart interface for custom analysis view builder
/// </summary>
public interface IChart3D
{
    /// <summary>
    /// Add some points to the 3d chart
    /// </summary>
    /// <param name="x">Array of X values</param>
    /// <param name="y">Array of Y values</param>
    /// <param name="z">Array of Z values</param>
    /// <param name="color">Color for the points</param>
    /// <param name="samplingCoefficient">How much to sample (1.0 = full?)</param>
    /// <returns></returns>
    void AddPoints(float[] x, float[] y, float[] z, Color color, decimal samplingCoefficient);

    /// <summary>
    /// Add a surface to the 3d chart.  Pass in indexed triangle array
    /// </summary>
    /// <param name="xPosition">Array of X values</param>
    /// <param name="yPosition">Array of Y values</param>
    /// <param name="zPosition">Array of Z values</param>
    /// <param name="indices">Array of indicies for surface</param>
    /// <param name="alternateIndices">Array of indicies for wireframe</param>
    /// <param name="color">Surface color</param>
    /// <returns></returns>
    void AddSurface(float[] xPosition, float[] yPosition, float[] zPosition, int[] indices, int[] alternateIndices, Color color);
}