using System;

namespace Cameca.CustomAnalysis.Interface;

public interface ISectionInfo
{
    Type Type { get; }
    string Unit { get; }
    ulong RecordCount { get; }
    uint ValuesPerRecord { get; }
    byte[] ExtraData { get; }
    bool IsVirtual { get; }
	bool IsProtected { get => false; }
	void UpdateExtraData(ReadOnlyMemory<byte> extraData) { }
}
