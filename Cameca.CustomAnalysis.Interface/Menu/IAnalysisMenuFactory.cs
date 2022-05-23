namespace Cameca.CustomAnalysis.Interface;

public interface IAnalysisMenuFactory
{
	AnalysisMenuLocation Location { get; }
	IMenuItemBase CreateMenuItem(IAnalysisMenuContext context);
}
