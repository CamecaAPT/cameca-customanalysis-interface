using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeInfoProvider
{
	INodeInfo? Resolve(Guid nodeId);
}
