using System;
using System.Threading;

namespace Cameca.CustomAnalysis.Interface;

public interface IProxigramAnalysis
{
    IProxigramResults Run(InterfaceSubgroupROI volume, IProxigramParameters parameters, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}
