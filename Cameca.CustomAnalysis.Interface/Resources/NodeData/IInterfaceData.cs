using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IInterfaceData
{
	IEnumerable<IInterfaceMetrics> InterfaceMetrics { get; }
}
