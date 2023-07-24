using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataProvider
{
	INodeData? Resolve(Guid nodeId);
}
