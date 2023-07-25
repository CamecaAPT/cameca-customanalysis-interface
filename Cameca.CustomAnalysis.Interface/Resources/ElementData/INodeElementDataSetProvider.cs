using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeElementDataSetProvider
{
	INodeElementDataSet? Resolve(Guid nodeId);
}
