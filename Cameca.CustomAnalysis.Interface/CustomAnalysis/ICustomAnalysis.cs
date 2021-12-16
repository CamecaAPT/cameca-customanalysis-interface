using Cameca.CustomAnalysis.Interface.IonData;
using Cameca.CustomAnalysis.Interface.View;

namespace Cameca.CustomAnalysis.Interface.CustomAnalysis
{
	/// <summary>
	/// Custom analyzes must implement this interface
	/// </summary>
	public interface ICustomAnalysis<TOptions> where TOptions : class, new()
	{
		/// <summary>
		/// Runs the analysis.
		/// </summary>
		/// <param name="ionData">The ion data.</param>
		/// <param name="parentNode">Parent Node.</param>
		/// <param name="options">The options.</param>
		/// <param name="viewBuilder">The view builder.</param>
		/// <returns></returns>
		IIonData Run(IIonData ionData, IAnalysisTreeNode parentNode, TOptions options, IViewBuilder viewBuilder);
	}
}
