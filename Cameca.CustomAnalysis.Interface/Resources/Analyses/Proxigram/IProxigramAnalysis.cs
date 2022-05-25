using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IProxigramAnalysis
{
    Task<IProxigramResults> Run(InterfaceSubgroupROI volume, ProxigramParameters parameters, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}
