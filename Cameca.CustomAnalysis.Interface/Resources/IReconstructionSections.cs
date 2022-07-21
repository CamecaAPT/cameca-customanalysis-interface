using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IReconstructionSections
{
	bool IsAddSectionAvailable { get; }
	Task<IEnumerable<ReconstructionSectionInfo>> GetAvailableSections(IProgress<double>? progress = null, CancellationToken cancellationToken = default);
	Task<bool> AddVirtualSections(IEnumerable<string> sectionNames, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}

public record ReconstructionSectionInfo(string Name, string Description);
