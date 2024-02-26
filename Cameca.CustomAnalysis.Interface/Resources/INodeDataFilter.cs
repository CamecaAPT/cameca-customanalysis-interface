namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataFilter
{
	GetIndicesDelegate? FilterDelegate { get; set; }
	GetIndicesDelegateSync? FilterSyncDelegate { get; set; }
	bool IsInverted { get; set; }
	string? FilterProgressMessage { get => null; set { } }
	void FilterDataChanged() { }
}
