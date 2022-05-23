namespace Cameca.CustomAnalysis.Interface;

public interface IExtensionRegistry
{
	void RegisterAnalysisView<TView, TViewModel>(AnalysisViewLocation location = AnalysisViewLocation.Default);
	void RegisterPreview(string nodeUniqueId, string viewModelUniqueId);
}
