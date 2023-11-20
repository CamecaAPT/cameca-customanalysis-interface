using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IProxigramAnalysis
{
	async Task<IProxigramData> Run(InterfaceSubgroupROI volume, IProxigramParameters parameters, IProgress<double>? progress = null, CancellationToken cancellationToken = default)
	{
		// Call obsolete method with default implementation until future breaking release
#pragma warning disable CS0618 // Type or member is obsolete
		return (IProxigramData)await Run(
			volume, new ProxigramParameters
			{
				BinSize = parameters.BinSize,
				MaximumDistance = parameters.MaximumDistance,
				// Modulus is removed from the interface, so just use default value
				ExcludeEdgePolygons = parameters.ExcludeEdgePolygons,
				SeparateProxigrams = parameters.SeparateProxigrams,
				SeparationType = parameters.SeparationType,
				VolumeBinSize = parameters.VolumeBinSize,
				AreaBinSize = parameters.AreaBinSize,
			},
			progress,
			cancellationToken);
#pragma warning restore CS0618 // Type or member is obsolete
	}

	[Obsolete("Use Run overload accepting IProxigramParameters and returning IProxigramData instead")]
	Task<IProxigramResults> Run(InterfaceSubgroupROI volume, ProxigramParameters parameters, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}
