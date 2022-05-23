using System;
using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonData
{
	string Filename { get; }
	ulong IonCount { get; }
	IReadOnlyDictionary<string, ISectionInfo> Sections { get; }
	void AddVirtualSection(string section, Type type, string unit = "", uint valuesPerRecord = 1);
	IEnumerator<IChunkState> CreateSectionDataEnumerator(params string[] sections);
	Extents Extents { get; }
	IReadOnlyList<IIonTypeInfo> Ions { get; }
	IReadOnlyDictionary<IIonTypeInfo, ulong> GetIonTypeCounts();
}