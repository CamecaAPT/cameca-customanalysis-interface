using System;
using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public struct IndexedTriangleArray
{
	ReadOnlyMemory<Vector3> Vertices { get; }
	ReadOnlyMemory<int> Indices { get; }
}
