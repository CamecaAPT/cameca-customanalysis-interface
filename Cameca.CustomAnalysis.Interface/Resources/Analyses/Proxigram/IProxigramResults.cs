using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IProxigramResults
{
    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedResults_Ionic { get;}

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdVals_WPositivity_Ionic { get;}

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdCorrectedVals_WPositivity_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdVals_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdCorrectedVals_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedErrors_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdCorrectedErrors_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<uint> DistributedCounts_Ionic { get; }

    ReadOnlyMemoryND<uint> DistributedSumCountsInBin_Ionic { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin]  
    /// </summary>
    ReadOnlyMemoryND<double> DistributedResults_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdVals_WPositivity_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdCorrectedVals_WPositivity_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdVals_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin] 
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdCorrectedVals_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin]  
    /// </summary>
    ReadOnlyMemoryND<double> DistributedErrors_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin]  
    /// </summary>
    ReadOnlyMemoryND<double> DistributedBckgdCorrectedErrors_Decomp { get; }

    /// <summary>
    /// 3D double array [ROIBin, IonType, XBin]  
    /// </summary>
    ReadOnlyMemoryND<uint> DistributedCounts_Decomp { get; }

    ReadOnlyMemoryND<uint> DistributedSumCountsInBin_Decomp { get; }

    /// <summary>
    /// Return raw proxigram count data.  3D unsigned int array [ROI, IonType, Bin] like Results
    /// </summary>
    ReadOnlyMemoryND<uint> IonCounts { get; }


    /// <summary>
    /// Return raw proxigram background count data.  3D unsigned float array [ROI, IonType, Bin]
    /// </summary>
    ReadOnlyMemoryND<double> BackgroundIonCounts { get; }


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