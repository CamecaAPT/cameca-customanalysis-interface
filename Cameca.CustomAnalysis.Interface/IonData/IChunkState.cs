using System;

namespace Cameca.CustomAnalysis.Interface.IonData;

public interface IChunkState
{
    int Index { get; }
    int Length { get; }
    ReadOnlySpan<T> ReadSectionDataChunk<T>(string section) where T : unmanaged;
    void WriteSectionDataChunk<T>(string section, ReadOnlyMemory<T> data) where T : unmanaged;
}