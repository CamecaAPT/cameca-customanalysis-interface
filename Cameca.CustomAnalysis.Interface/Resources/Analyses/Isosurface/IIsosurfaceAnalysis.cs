using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IIsosurfaceAnalysis
{
    Task<ReadOnlyMemory<GridGeneratedInterface>> BuildIsosurface(BuildIsosurfaceParameters parameters, float isoLevel, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
    Task<IInterfaceMetrics> CalculateInterfaceMetrics(IndexedTriangleArray interfaceMesh, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}
