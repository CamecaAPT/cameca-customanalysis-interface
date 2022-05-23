using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeDisplayInfo
{
	string Title { get; }
	ImageSource? Icon { get; }
}
