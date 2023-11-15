using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IChunkState : IDisposable
{
    int Index { get; }
    int Length { get; }
    ReadOnlyMemory<T> ReadSectionData<T>(string section) where T : unmanaged;
    void WriteSectionData<T>(string section, ReadOnlyMemory<T> data) where T : unmanaged;
	void WriteIndexedSectionData<T>(string section, ReadOnlyMemory<T> data, ReadOnlyMemory<int> indices) where T : unmanaged
	{
		// Default implementation copies full section, updates by index, and writes all
		// A real implementation should natively updated data only for the specified indices
		if (data.Length != indices.Length) throw new ArgumentException("Data and indices must be the same length");
		var src = ReadSectionData<T>(section);
		var buffer = new T[src.Length];
		src.CopyTo(buffer);
		for (int i = 0; i < indices.Length; i++)
		{
			buffer[indices.Span[i]] = data.Span[i];
		}
		WriteSectionData<T>(section, buffer);
	}
	void IDisposable.Dispose() { }
}
