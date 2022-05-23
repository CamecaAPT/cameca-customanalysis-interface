using System;
using System.Threading;

namespace Cameca.CustomAnalysis.Interface;

public interface IIsosurfaceAnalysis
{
    ReadOnlyMemory<IndexedTriangleArray> BuildIsosurface(IBuildIsosurfaceParameters parameters, float isoLevel, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
    IInterfaceMetrics CalculateInterfaceMetrics(IndexedTriangleArray interfaceMesh, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}