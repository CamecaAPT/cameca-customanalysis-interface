using System.ComponentModel;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IChart2DSlice : INotifyPropertyChanged
{
	float Min { get; }
	float Max { get; }
	Color Color { get; set; }
	bool IsSelected { get; set; }
	void SetBounds(float min, float max) { }
}
