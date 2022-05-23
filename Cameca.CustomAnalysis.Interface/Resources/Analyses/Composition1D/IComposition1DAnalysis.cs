using System;
using System.Threading;

namespace Cameca.CustomAnalysis.Interface;

public interface IComposition1DAnalysis
{
    IComposition1DResults Run(IComposition1DParameters parameters, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}