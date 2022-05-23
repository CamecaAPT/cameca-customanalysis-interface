using System.ComponentModel;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataState : INotifyPropertyChanged
{
	bool IsErrorState { get; set; }
	bool IsValid { get; set; }
}