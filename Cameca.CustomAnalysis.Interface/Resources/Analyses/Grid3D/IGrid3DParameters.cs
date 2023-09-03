using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public interface IGrid3DParameters
{
	Vector3 VoxelSize { get; }
	Vector3 BuildGrid { get; }
	bool ErodeByDelocalization { get; }
	bool DoFirstPassDeloc { get; }
}
