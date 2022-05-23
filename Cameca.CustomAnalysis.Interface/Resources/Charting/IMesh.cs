using System;
using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public interface IMesh
{
	ReadOnlyMemory<Vector3> Vertices { get; }
	ReadOnlyMemory<int> Indices { get; }
}
