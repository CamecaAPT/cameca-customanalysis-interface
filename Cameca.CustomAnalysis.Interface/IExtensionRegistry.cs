using System;
using System.ComponentModel;
using System.Windows.Controls;

namespace Cameca.CustomAnalysis.Interface;

public interface IExtensionRegistry
{
	void RegisterAnalysisView<TView, TViewModel>(AnalysisViewLocation location = AnalysisViewLocation.Default);
	void RegisterPreview(string nodeUniqueId, string viewModelUniqueId);
	void RegisterOptions<TOptionsModel>(string title, Version? version = null)
		where TOptionsModel : class, new()
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
	void RegisterOptions<TOptionsModel, TView, TViewModel>(string title, Version? version = null)
		where TOptionsModel : class, IEquatable<TOptionsModel>, ICloneable, INotifyPropertyChanged, new()
		where TView : Control, new()
		where TViewModel : class, IOptionsViewModel<TOptionsModel>
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
}
