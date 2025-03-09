using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IGrid3DData
{
	int[] NumVoxels { get; }

	double[] VoxelSize { get; }

	double[] GridDelta { get; }

	double[,] GridRange { get; }

	/// <summary>
	/// Gets the grid data for an ion type given the index into the <see cref="IIonData.Ions"/> list
	/// A flattened 3D array (order X->Y->Z)
	/// </summary>
	ReadOnlyMemory<float> GetDataForIon(int ionIndex);
}
