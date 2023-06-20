namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataFilter
{
	GetIndicesDelegate? FilterDelegate { get; set; }
	bool IsInverted { get; set; }
	string? FilterProgressMessage { get; set; }
}
