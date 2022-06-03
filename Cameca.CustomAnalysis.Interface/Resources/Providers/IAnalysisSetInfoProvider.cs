using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IAnalysisSetInfoProvider
{
	IAnalysisSetInfo? Resolve(Guid nodeId);
}
