using System;

namespace Cameca.CustomAnalysis.Interface.IonData;

public interface IIonDataReader
{
    public void GetSectionRecords<T>(IIonData ionData, string section1, Action<T> action)
        where T : unmanaged;

    public void GetSectionRecords<T1, T2>(IIonData ionData, string section1, string section2, Action<T1, T2> action)
        where T1 : unmanaged
        where T2 : unmanaged;

    public void GetSectionRecords<T1, T2, T3>(IIonData ionData, string section1, string section2, string section3, Action<T1, T2, T3> action)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged;

    public void GetSectionRecords<T1, T2, T3, T4>(IIonData ionData, string section1, string section2, string section3, string section4, Action<T1, T2, T3, T4> action)
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged;

}