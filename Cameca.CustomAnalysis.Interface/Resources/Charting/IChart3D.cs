using System.Collections.ObjectModel;

namespace Cameca.CustomAnalysis.Interface;

public interface IChart3D
{
	ObservableCollection<IRenderData> DataSource { get; }
}