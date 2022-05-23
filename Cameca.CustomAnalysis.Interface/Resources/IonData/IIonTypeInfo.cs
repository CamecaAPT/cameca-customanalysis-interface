namespace Cameca.CustomAnalysis.Interface;

public interface IIonTypeInfo
{
    string Name { get; }
    IIonFormula Formula { get; }
    double Volume { get; }
}