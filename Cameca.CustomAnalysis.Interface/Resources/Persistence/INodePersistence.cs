namespace Cameca.CustomAnalysis.Interface;

public interface INodePersistence
{
	SaveDelegate? SaveDelegate { get; set; }
	SaveDelegate? SavePreviewDelegate { get; set; }
}
