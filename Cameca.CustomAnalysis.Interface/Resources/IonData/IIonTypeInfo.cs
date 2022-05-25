namespace Cameca.CustomAnalysis.Interface;

public interface IIonTypeInfo
{
    string Name { get; }
    IonFormula Formula { get; }
    double Volume { get; }
}