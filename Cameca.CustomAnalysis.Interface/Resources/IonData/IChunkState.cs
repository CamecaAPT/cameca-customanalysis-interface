using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IChunkState
{
    int Index { get; }
    int Length { get; }
    ReadOnlyMemory<T> ReadSectionData<T>(string section) where T : unmanaged;
    void WriteSectionData<T>(string section, ReadOnlyMemory<T> data) where T : unmanaged;
}