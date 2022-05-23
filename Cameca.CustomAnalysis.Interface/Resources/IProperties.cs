using System.ComponentModel;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeProperties : INotifyPropertyChanged
{
	object? Properties { get; set; }
}