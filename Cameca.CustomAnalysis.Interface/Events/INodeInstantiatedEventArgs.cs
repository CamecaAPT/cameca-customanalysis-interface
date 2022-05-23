using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeInstantiatedEventArgs
{
	Guid NodeId { get; }
}
