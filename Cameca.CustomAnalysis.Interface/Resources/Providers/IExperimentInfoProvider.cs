using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IExperimentInfoProvider
{
	IExperimentInfoResolver? Resolve(Guid nodeId);
}
