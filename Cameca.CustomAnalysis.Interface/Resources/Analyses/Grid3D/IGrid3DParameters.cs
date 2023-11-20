using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public interface IGrid3DParameters
{
	Vector3 VoxelSize { get; }
	Vector3 Delocalization { get; }
	bool ErodeByDelocalization { get; }
	bool DoFirstPassDeloc { get; }
}
