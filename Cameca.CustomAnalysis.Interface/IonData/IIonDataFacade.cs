using System;
using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface.IonData;

public interface IIonDataFacade
{
    void AddVirtualSection(string section, Type type, string unit = "", uint valuesPerRecord = 1);
    public void IterateSectionData(IonDataChunkDelegate chunkDelegate);
    public void IterateSectionData(IonDataChunkDelegate chunkDelegate, IEnumerable<string> sections);
}