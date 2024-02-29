using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonDataResolver
{
	Guid OwnerNodeId { get; }
	Task<IIonData?> GetIonData(IProgress<double>? progress = null, CancellationToken cancellationToken = default);
	/// <summary>
	/// Resolve the <see cref="IIonData"/> instance for the current scope. Blocking resolution of instance if not immediately available.
	/// </summary>
	/// <remarks>
	/// Should not return <c>null</c> unless cancelled.
	/// </remarks>
	/// <param name="progress"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	IIonData? GetIonDataSync(IProgress<double>? progress = null, CancellationToken cancellationToken = default)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
	/// <summary>
	/// Returns a cached <see cref="IIonData"/> instance if available. Does not resolve if not available.
	/// </summary>
	/// <remarks>
	/// Returns null if instance is not immediately available and requires possibly lengthy recalculation.
	/// </remarks>
	/// <returns></returns>
	IIonData? GetValidIonData();
}
