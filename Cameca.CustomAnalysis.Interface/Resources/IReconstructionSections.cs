using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IReconstructionSections
{
	bool IsAddSectionAvailable { get; }

	Task<IEnumerable<ReconstructionSectionInfo>> GetAvailableSections(IProgress<double>? progress = null, CancellationToken cancellationToken = default);
	IEnumerable<ReconstructionSectionInfo> GetAvailableSectionsSync(IProgress<double>? progress = null, CancellationToken cancellationToken = default)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();

	Task<bool> AddSections(IEnumerable<string> sectionNames, bool isVirtual = false, IProgress<double>? progress = null, CancellationToken cancellationToken = default)
	{
#pragma warning disable CS0618 // Type or member is obsolete
		if (isVirtual) return AddVirtualSections(sectionNames, progress, cancellationToken);
#pragma warning restore CS0618 // Type or member is obsolete
		return Task.FromResult(false);
	}
	bool AddSectionsSync(IEnumerable<string> sectionNames, bool isVirtual = false, IProgress<double>? progress = null, CancellationToken cancellationToken = default)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();

	[Obsolete("Use AddSections with isVirtual: true")]
	Task<bool> AddVirtualSections(IEnumerable<string> sectionNames, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}

public record ReconstructionSectionInfo(string Name, string Description);
