using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IIsosurfaceAnalysis
{
	Task<ReadOnlyMemory<GridGeneratedInterface>> BuildIsosurface(BuildIsosurfaceParameters parameters, float isoLevel, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
	ReadOnlyMemory<GridGeneratedInterface> BuildIsosurfaceSync(BuildIsosurfaceParameters parameters, float isoLevel, IProgress<double>? progress = null, CancellationToken cancellationToken = default)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
	Task<IInterfaceMetrics> CalculateInterfaceMetrics(IndexedTriangleArray interfaceMesh, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
	IInterfaceMetrics CalculateInterfaceMetricsSync(IndexedTriangleArray interfaceMesh, IProgress<double>? progress = null, CancellationToken cancellationToken = default)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
}
