using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonRatio
{
    IReadOnlyCollection<IIonFormula> IonNumerators { get; }
    IReadOnlyCollection<IIonFormula> IonDenominators { get; }
}