using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IProxigramAnalysisProvider
{
	IProxigramAnalysis? Resolve(Guid nodeId);
}