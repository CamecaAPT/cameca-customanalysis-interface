using System;

namespace Cameca.CustomAnalysis.Interface;

public struct ReadOnlyMemory2<T>
{
    public ReadOnlyMemory<T> Memory;
    public int Stride;

    public ReadOnlyMemory2(ReadOnlyMemory<T> memory, int stride)
    {
        Memory = memory;
        Stride = stride;
    }
}