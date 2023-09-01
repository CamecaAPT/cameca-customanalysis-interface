namespace Cameca.CustomAnalysis.Interface;

public interface IProxigramParameters
{
	float BinSize { get; }
	float MaximumDistance { get; }
	bool ExcludeEdgePolygons { get; }
	bool SeparateProxigrams { get; }
	SeparationType SeparationType { get; }
	float VolumeBinSize { get; }
	float AreaBinSize { get; }
}
