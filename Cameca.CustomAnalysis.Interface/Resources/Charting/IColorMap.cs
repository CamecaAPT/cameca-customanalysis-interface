using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IColorMap : INotifyPropertyChanged
{
	Color Bottom { get; set; }
	Color NanColor { get; set; }
	Color OutOfRangeBottom { get; set; }
	Color OutOfRangeTop { get; set; }
	Color Top { get; set; }
	ObservableCollection<IColorStop> ColorStops { get; }
}
