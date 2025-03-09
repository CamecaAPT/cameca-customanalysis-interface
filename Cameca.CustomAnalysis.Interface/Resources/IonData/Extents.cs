using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public readonly struct Extents
{
	public Vector3 Min { get; init; }
	public Vector3 Max { get; init; }
}
