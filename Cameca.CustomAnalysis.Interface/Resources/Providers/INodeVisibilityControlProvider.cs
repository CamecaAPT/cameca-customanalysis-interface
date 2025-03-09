using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeVisibilityControlProvider
{
	INodeVisibilityControl? Resolve(Guid nodeId);
}