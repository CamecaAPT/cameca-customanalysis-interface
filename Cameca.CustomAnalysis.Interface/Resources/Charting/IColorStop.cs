using System.ComponentModel;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IColorStop : INotifyPropertyChanged
{
	Color BottomColor { get; set; }
	float RelativePosition { get; set; }
	Color TopColor { get; set; }
}
