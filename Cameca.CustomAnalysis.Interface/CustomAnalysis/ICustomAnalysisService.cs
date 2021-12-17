using System;
using System.ComponentModel;

namespace Cameca.CustomAnalysis.Interface.CustomAnalysis
{
	/// <summary>
	/// Interface for registration Custom Analyses.
	/// </summary>
	public interface ICustomAnalysisService
	{
		/// <summary>
		/// Register a custom analysis without code
		/// </summary>
		/// <typeparam name="TAnalysis">Type of the analysis</typeparam>
		/// <typeparam name="TOptions">Type of the analysis options</typeparam>
		/// <param name="description">Custom analysis description instance</param>
		void Register<TAnalysis, TOptions>(CustomAnalysisDescription description)
			where TAnalysis : class, ICustomAnalysis<TOptions> where TOptions : class, INotifyPropertyChanged, new();

		/// <summary>
		/// Register a custom analysis with code
		/// </summary>
		/// <typeparam name="TAnalysis">Type of the analysis</typeparam>
		/// <typeparam name="TOptions">Type of the analysis options</typeparam>
		/// <typeparam name="TCode">Type of the custom code entry point/class</typeparam>
		/// <param name="description">Custom analysis description instance</param>
		/// <param name="defaultCodeGetter">Function to get default/sample code</param>
		void Register<TAnalysis, TOptions, TCode>(CustomAnalysisDescription description, Func<string> defaultCodeGetter)
			where TAnalysis : class, ICustomAnalysisWithCode<TOptions, TCode>, new() where TOptions : class, INotifyPropertyChanged, new();
	}
}
