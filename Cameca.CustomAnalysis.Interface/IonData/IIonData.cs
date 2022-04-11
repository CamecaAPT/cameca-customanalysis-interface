using System;

namespace Cameca.CustomAnalysis.Interface.IonData;

public interface IIonData : IDisposable
{
    string Filename { get; }
    ulong IonCount { get; }
    bool ReturnTransformedPoints { get; set; }
    IMassData MassData { get; }
    IIonTypeData IonTypeData { get; }
    IPositionData PositionData { get; }
    IIonDataInfo GetIonDataInfo();
}