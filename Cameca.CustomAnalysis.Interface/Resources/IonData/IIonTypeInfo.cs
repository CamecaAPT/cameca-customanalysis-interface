using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonTypeInfo
{
    string Name { get; }
    IReadOnlyList<IElement> Formula { get; }
    double Volume { get; }
}