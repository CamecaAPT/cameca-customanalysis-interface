using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface.IonData
{
	public interface IIonDataInfo
	{
		IAptFileInfo FileInfo { get; }
		Dictionary<string, ISectionInfo> SectionInfo { get; }
	}
}
