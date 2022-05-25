using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodePersistenceProvider
{
	INodePersistence? Resolve(Guid nodeId);
}
