namespace Cameca.CustomAnalysis.Interface;

public interface INodeSaveInterceptor
{
	SaveDelegate? SaveInterceptor { get; set; }
	SaveDelegate? SavePreviewInterceptor { get; set; }
}