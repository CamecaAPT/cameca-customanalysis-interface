namespace Cameca.CustomAnalysis.Interface;

public interface IProxigramParameters
{
    float BinSize { get; }
    float MaximumDistance { get; }
    int Modulus { get; }
    bool ExcludeEdgePolygons { get; }
    SeparationType SeparationType { get; }
    float VolumeBinSize { get; }
    float AreaBinSize { get; }
}