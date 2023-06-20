using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IExportToCsv
{
    Task<ExportToCsvResult> ExportToCsv(string path, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}

public record ExportToCsvResult(bool Success, string? Message);