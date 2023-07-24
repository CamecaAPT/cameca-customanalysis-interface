using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IMeshData
{
	IEnumerable<IndexedTriangleArray> IndexedTriangleArray { get; }
}
