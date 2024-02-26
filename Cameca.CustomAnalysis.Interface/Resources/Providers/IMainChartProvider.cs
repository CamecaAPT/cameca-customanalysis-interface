using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IMainChartProvider
{
	IChart3D? Resolve(Guid nodeId);
}