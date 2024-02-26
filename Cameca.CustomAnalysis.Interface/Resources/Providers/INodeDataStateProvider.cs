using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataStateProvider
{
	INodeDataState? Resolve(Guid nodeId);
}