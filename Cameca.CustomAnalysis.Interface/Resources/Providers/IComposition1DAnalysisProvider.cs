using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IComposition1DAnalysisProvider
{
	IComposition1DAnalysis? Resolve(Guid nodeId);
}