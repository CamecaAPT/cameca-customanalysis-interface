using System.ComponentModel;

namespace Cameca.CustomAnalysis.Interface;

public interface ICanSaveState : INotifyPropertyChanged
{
	bool CanSave { get; set; }
}