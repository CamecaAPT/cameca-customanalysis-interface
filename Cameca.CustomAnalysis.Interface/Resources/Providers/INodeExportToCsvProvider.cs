using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeExportToCsvProvider
{
	INodeExportToCsv? Resolve(Guid nodeId);
}
