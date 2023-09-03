using System;
using CommunityToolkit.HighPerformance;

namespace Cameca.CustomAnalysis.Interface;

#pragma warning disable CS0618 // Type or member is obsolete
public interface IProxigramData : IProxigramResults { }
#pragma warning restore CS0618 // Type or member is obsolete

[Obsolete("Use IProxigramData instead")]
public interface IProxigramResults
{
    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedResults_Ionic { get;}

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdVals_WPositivity_Ionic { get;}

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdCorrectedVals_WPositivity_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdVals_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdCorrectedVals_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedErrors_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdCorrectedErrors_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<uint>[] DistributedCounts_Ionic { get; }

    ReadOnlyMemory2D<uint> DistributedSumCountsInBin_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin]  
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedResults_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdVals_WPositivity_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdCorrectedVals_WPositivity_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdVals_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdCorrectedVals_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin]  
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedErrors_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin]  
    /// </summary>
    ReadOnlyMemory2D<double>[] DistributedBckgdCorrectedErrors_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin]  
    /// </summary>
    ReadOnlyMemory2D<uint>[] DistributedCounts_Decomp { get; }

    ReadOnlyMemory2D<uint> DistributedSumCountsInBin_Decomp { get; }

    /// <summary>
    /// Return raw proxigram count data.  3D unsigned int array [ROI, IonType, Bin] like Results
    /// </summary>
    ReadOnlyMemory2D<uint>[] IonCounts { get; }


    /// <summary>
    /// Return raw proxigram background count data.  3D unsigned float array [ROI, IonType, Bin]
    /// </summary>
    ReadOnlyMemory2D<double>[] BackgroundIonCounts { get; }


    /// <summary>
    /// X Values for chart
    /// </summary>
    ReadOnlyMemory<double> XValues { get; }

    bool HasBackground { get; } 

    int NumRoiBins { get; }
    double RoiBinSize { get; }
    double RoiBinMin { get; }
    int NumIonTypes { get; }
    int NumBins { get; }
    double BinSize { get; }
}
