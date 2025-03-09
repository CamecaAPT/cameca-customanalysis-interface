using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IExportToCsv
{
	Task<ExportToCsvResult> ExportToCsv(string path, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
	ExportToCsvResult ExportToCsvSync(string path, IProgress<double>? progress = null, CancellationToken cancellationToken = default)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
}

public record ExportToCsvResult(bool Success, string? Message);
