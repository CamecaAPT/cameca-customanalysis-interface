using System;
using System.ComponentModel;
using System.Windows.Controls;

namespace Cameca.CustomAnalysis.Interface;

public interface IExtensionRegistry
{
	void RegisterAnalysisView<TView, TViewModel>(AnalysisViewLocation location = AnalysisViewLocation.Default);
	void RegisterPreview(string nodeUniqueId, string viewModelUniqueId);
	/// <summary>
	/// Register extension options with a custom view.
	/// </summary>
	/// <typeparam name="TOptionsModel"></typeparam>
	/// <param name="title">The display title for this options view in the Configuration panel</param>
	/// <param name="version">A version value for options. When version is changes, existing saved options are not loaded. This allows changing the class without deserialization issues. Default value = 1.0.0.</param>
	/// <param name="uniqueModelIdentifier">
	/// Saving options requires a globally unique identifier. If left null, this value is resolved to the fully qualified type name of <typeparamref name="TOptionsModel"/>.
	/// If creating a reusable library that defines its own options, providing a separate ID may be required to avoid each extension referening that library from sharing the same options.
	/// This value can nearly always be left null. Only set this to a value if creating a reusable extension supporting library that defines options that should not be shared accross all consuming extensions.
	/// </param>
	void RegisterOptions<TOptionsModel>(string title, Version? version = null, string? uniqueModelIdentifier = null)
		where TOptionsModel : class, new()
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
	/// <summary>
	/// Register a serializable class as extension options.
	/// </summary>
	/// <remarks>
	/// AP Suite dynamically generates an editor for the Configuration panel.
	/// </remarks>
	/// <typeparam name="TOptionsModel"></typeparam>
	/// <typeparam name="TView"></typeparam>
	/// <typeparam name="TViewModel"></typeparam>
	/// <param name="title">The display title for this options view in the Configuration panel</param>
	/// <param name="version">A version value for options. When version is changes, existing saved options are not loaded. This allows changing the class without deserialization issues. Default value = 1.0.0.</param>
	/// <param name="uniqueModelIdentifier">
	/// Saving options requires a globally unique identifier. If left null, this value is resolved to the fully qualified type name of <typeparamref name="TOptionsModel"/>.
	/// If creating a reusable library that defines its own options, providing a separate ID may be required to avoid each extension referening that library from sharing the same options.
	/// This value can nearly always be left null. Only set this to a value if creating a reusable extension supporting library that defines options that should not be shared accross all consuming extensions.
	/// </param>
	void RegisterOptions<TOptionsModel, TView, TViewModel>(string title, Version? version = null, string? uniqueModelIdentifier = null)
		where TOptionsModel : class, IEquatable<TOptionsModel>, ICloneable, INotifyPropertyChanged, new()
		where TView : Control, new()
		where TViewModel : class, IOptionsViewModel<TOptionsModel>
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
}
