using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IExportToCsvProvider
{
	IExportToCsv? Resolve(Guid nodeId);
}
