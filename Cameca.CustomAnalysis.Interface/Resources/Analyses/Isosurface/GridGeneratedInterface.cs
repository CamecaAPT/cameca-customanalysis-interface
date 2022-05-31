namespace Cameca.CustomAnalysis.Interface;

public readonly struct GridGeneratedInterface
{
	public readonly IndexedTriangleArray Mesh;
	public readonly GeneratingGridMetrics GeneratingGridMetrics;

	public GridGeneratedInterface(IndexedTriangleArray mesh, GeneratingGridMetrics generatingGridMetrics)
	{
		Mesh = mesh;
		GeneratingGridMetrics = generatingGridMetrics;
	}

}
