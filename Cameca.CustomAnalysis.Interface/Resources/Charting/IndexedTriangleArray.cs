using System;
using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public readonly struct IndexedTriangleArray
{
	public readonly ReadOnlyMemory<Vector3> Vertices;
	public readonly ReadOnlyMemory<int> Indices;
	
	public IndexedTriangleArray(ReadOnlyMemory<Vector3> vertices, ReadOnlyMemory<int> indices)
	{
		Vertices = vertices;
		Indices = indices;
	}
}
