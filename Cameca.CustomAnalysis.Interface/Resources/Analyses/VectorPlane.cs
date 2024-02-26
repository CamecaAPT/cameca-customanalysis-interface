using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public readonly struct VectorPlane
{
	public readonly Vector3 X;
	public readonly Vector3 Y;
	public readonly Vector3 Z;

	public VectorPlane(Vector3 x, Vector3 y, Vector3 z)
	{
		X = x;
		Y = y;
		Z = z;
	}
}