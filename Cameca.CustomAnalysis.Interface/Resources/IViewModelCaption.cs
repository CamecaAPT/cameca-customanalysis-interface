using System.ComponentModel;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IViewModelCaption : INotifyPropertyChanged
{
	string Caption { get; set; }
	ImageSource? CaptionImage { get; set; }
}
