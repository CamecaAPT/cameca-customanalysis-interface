namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataFilterInterceptor
{
	GetIndicesDelegate? FilterDelegate { get; set; }
	bool IsInverted { get; set; }
}