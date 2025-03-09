using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataFilterProvider
{
	INodeDataFilter? Resolve(Guid nodeId);
}
