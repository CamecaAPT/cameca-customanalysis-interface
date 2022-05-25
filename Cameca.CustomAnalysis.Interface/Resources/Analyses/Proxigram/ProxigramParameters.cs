namespace Cameca.CustomAnalysis.Interface;

public class ProxigramParameters
{
	public const float DefaultBinSize = 0.1f;
	public const float DefaultMaximumDistance = 1.0f;
	public const int DefaultModulus = 1;
	public const bool DefaultExcludeEdgePolygons = true;
	public const SeparationType DefaultSeparationType = SeparationType.Volume;
	public const float DefaultVolumeBinSize = 1.0f;
	public const float DefaultAreaBinSize = 1.0f;

	public float BinSize { get; init; } = DefaultBinSize;

	public float MaximumDistance { get; init; } = DefaultMaximumDistance;

	public int Modulus { get; init; } = DefaultModulus;

	public bool ExcludeEdgePolygons { get; init; } = DefaultExcludeEdgePolygons;

	public SeparationType SeparationType { get; init; } = DefaultSeparationType;

	public float VolumeBinSize { get; init; } = DefaultVolumeBinSize;

	public float AreaBinSize { get; init; } = DefaultAreaBinSize;
}
