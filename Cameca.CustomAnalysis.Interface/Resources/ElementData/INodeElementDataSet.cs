using System.ComponentModel;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeElementDataSet : INotifyPropertyChanged
{
	int ElementDataSetId { get; set; }
}
