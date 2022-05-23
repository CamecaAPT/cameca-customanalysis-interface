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
}