using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public readonly struct GeneratingGridMetrics
{
	public readonly Extents Extents;
	public readonly Vector3 VoxelSize;

	public GeneratingGridMetrics(Extents extents, Vector3 voxelSize)
	{
		Extents = extents;
		VoxelSize = voxelSize;
	}
}
