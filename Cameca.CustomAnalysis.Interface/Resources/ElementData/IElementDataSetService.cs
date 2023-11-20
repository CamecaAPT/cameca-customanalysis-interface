using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IElementDataSetService
{
	IElementDataSet GetDefaultElementDataSet();
	IEnumerable<IElementDataSet> GetAllElementDataSets();
	IElementDataSet? GetElementDataSet(int elementDataSetId);
}
