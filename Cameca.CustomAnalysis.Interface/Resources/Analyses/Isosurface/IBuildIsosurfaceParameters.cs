namespace Cameca.CustomAnalysis.Interface;

public interface IBuildIsosurfaceParameters
{
    IIonRatio IonRatio { get; }
    ProfileType ProfileType { get; }
    bool AtomicDecomposed { get; }
}