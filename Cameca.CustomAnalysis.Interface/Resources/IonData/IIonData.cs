using System;
using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonData
{
	string Filename { get; }
	ulong IonCount { get; }
	IReadOnlyDictionary<string, ISectionInfo> Sections { get; }
	[Obsolete("Prefer AddSection with isVirtual: true")]
	void AddVirtualSection(string section, Type type, string unit = "", uint valuesPerRecord = 1);
	IEnumerator<IChunkState> CreateSectionDataEnumerator(params string[] sections);
	Extents Extents { get; }
	IReadOnlyList<IIonTypeInfo> Ions { get; }
	IReadOnlyDictionary<IIonTypeInfo, ulong> GetIonTypeCounts();
	bool CanWrite { get => false; }
	void AddSection(string section, Type type, ulong? recordCount, uint dataTypeBits, string unit = "", uint valuesPerRecord = 1u, bool isVirtual = false) { }
	bool DeleteSection(string section) { return false; }
}
