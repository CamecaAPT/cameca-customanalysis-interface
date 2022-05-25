using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonRatio
{
    IReadOnlyCollection<IonFormula> IonNumerators { get; }
    IReadOnlyCollection<IonFormula> IonDenominators { get; }
}