using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeMenuFactoryProvider
{
	INodeMenuFactory? Resolve(Guid nodeId);
}
