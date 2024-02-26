using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IComposition1DAnalysis
{
	async Task<IComposition1DData> Run(IComposition1DParameters parameters, IProgress<double>? progress = null, CancellationToken cancellationToken = default)
	{
		// Call obsolete method with default implementation until future breaking release
#pragma warning disable CS0618 // Type or member is obsolete
		return (IComposition1DData)await Run(
			new Composition1DParameters
			{
				Mode = parameters.Mode,
				Direction = parameters.Direction,
				BinWidth = parameters.BinWidth,
				IonsPerSample = parameters.IonsPerSample,
				IonsPerStep = parameters.IonsPerStep,
			},
			progress,
			cancellationToken);
#pragma warning restore CS0618 // Type or member is obsolete
	}
	IComposition1DData RunSync(IComposition1DParameters parameters, IProgress<double>? progress = null, CancellationToken cancellationToken = default);

	[Obsolete("Use Run overload accepting IComposition1DParameters and returning IComposition1DData instead")]
	Task<IComposition1DResults> Run(Composition1DParameters parameters, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}
