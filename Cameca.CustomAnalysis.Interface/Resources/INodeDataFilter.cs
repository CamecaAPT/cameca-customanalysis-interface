namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataFilter
{
	GetIndicesDelegate? FilterDelegate { get; set; }
	// Default implementations doesn't work well for read/write properties. This is more just a one time registration;
	// it barely benefits from having the get in the first place. Just seperatate out into a get and set method
	// See DefaultImplementationHelper for some mmore compatibiltity information
	GetIndicesDelegateSync? GetFilterDelegateSync()
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
	void SetFilterDelegateSync(GetIndicesDelegateSync? filterDelegateSync)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
	bool IsInverted { get; set; }
	string? FilterProgressMessage { get => null; set { } }
	void FilterDataChanged() { }
}
