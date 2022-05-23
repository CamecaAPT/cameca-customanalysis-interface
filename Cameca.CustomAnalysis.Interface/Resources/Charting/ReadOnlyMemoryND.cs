using System;

namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// N-Dimensional memory defined by a flat <see cref="ReadOnlyMemory{T}"/> plus a shape vector defining the size of each dimension
/// </summary>
/// <typeparam name="T"></typeparam>
public struct ReadOnlyMemoryND<T>
{
    public ReadOnlyMemory<T> Memory;
    public int[] Shape;

    public ReadOnlyMemoryND(ReadOnlyMemory<T> memory, int[] shape)
    {
        Memory = memory;
        Shape = shape;
    }
}