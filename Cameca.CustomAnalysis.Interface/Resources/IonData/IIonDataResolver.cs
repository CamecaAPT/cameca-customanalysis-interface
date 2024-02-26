using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonDataResolver
{
	Guid OwnerNodeId { get; }
	Task<IIonData?> GetIonData(IProgress<double>? progress = null, CancellationToken cancellationToken = default);
	IIonData? GetValidIonData();
}
