namespace Cameca.CustomAnalysis.Interface;

public interface IAnalysisMenuFactory
{
	AnalysisMenuLocation Location { get; }
	IMenuItem CreateMenuItem(IAnalysisMenuContext context);
}
