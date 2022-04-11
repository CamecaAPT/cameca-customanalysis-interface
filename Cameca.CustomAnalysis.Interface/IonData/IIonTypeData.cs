using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface.IonData;

public interface IIonTypeData
{
    long IonCount();
    IIonTypeInfo IonTypeInfo { get; }
    IReadOnlyList<int> IonCountsPerType();
    void InvalidateIonCountsPerType();
    void DoneWriting();
}