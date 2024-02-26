using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IIsosurfaceAnalysisProvider
{
	IIsosurfaceAnalysis? Resolve(Guid nodeId);
}