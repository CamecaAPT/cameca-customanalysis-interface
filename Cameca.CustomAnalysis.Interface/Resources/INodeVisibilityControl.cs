using System.ComponentModel;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeVisibilityControl : INotifyPropertyChanged
{
	bool IsEnabled { get; set; }
	bool IsVisible { get; set; }
}