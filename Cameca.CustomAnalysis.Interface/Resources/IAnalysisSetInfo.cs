using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IAnalysisSetInfo
{
	string Title { get; }
	Guid? SelectedNodeId { get; }
	Guid? SelectedViewModelId { get; }
}
