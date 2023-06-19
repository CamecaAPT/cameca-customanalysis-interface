using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeExportToCsv
{
    Task<ExportToCsvResult> ExportToCsv(string path, IProgress<double> progress, CancellationToken cancellationToken);
}

public record ExportToCsvResult(bool Success, string? Message);