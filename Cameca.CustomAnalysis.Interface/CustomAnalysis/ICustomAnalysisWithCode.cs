using Cameca.CustomAnalysis.Interface.IonData;
using Cameca.CustomAnalysis.Interface.View;

namespace Cameca.CustomAnalysis.Interface.CustomAnalysis
{

	/// <summary>
	/// Interface for the custom analysis node code
	/// </summary>
	/// <typeparam name="TOptions">Type of the option</typeparam>
	/// <typeparam name="TCode">Type of the parameters</typeparam>
	public interface ICustomAnalysisWithCode<TOptions, in TCode> where TOptions : class, new()
	{
		/// <summary>
		/// Custom analysis function to be run by Ivas
		/// </summary>
		/// <param name="ionData">The ion data.</param>
		/// <param name="parentNode">Parent node</param>
		/// <param name="options">Options instance</param>
		/// <param name="viewBuilder">Access to the view builder for data output</param>
		/// <param name="code">Custom analysis code instance</param>
		/// <returns></returns>
		IIonData Run(IIonData ionData, IAnalysisTreeNode parentNode, TOptions options, IViewBuilder viewBuilder, TCode code);
	}
}
