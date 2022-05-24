using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IComposition1DAnalysis
{
    Task<IComposition1DResults> Run(IComposition1DParameters parameters, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}