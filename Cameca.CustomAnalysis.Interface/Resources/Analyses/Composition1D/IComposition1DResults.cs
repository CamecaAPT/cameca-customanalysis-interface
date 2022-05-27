using System;
using System.Collections.Generic;
using Microsoft.Toolkit.HighPerformance;

namespace Cameca.CustomAnalysis.Interface;

public interface IComposition1DResults
{
	/// <summary>
	/// 1d concentration profile data - Ionic.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedYVals_Ionic { get; }

	/// <summary>
	/// 1d profile background data w/positivity constraint - Ionic.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedBckgdVals_WPositivity_Ionic { get; }

	/// <summary>
	/// 1d  background corrected profile data w/positivity constraint - Ionic.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistBckgdCorrectedVals_WPositivity_Ionic { get; }

	/// <summary>
	/// 1d profile background data - Ionic.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedBckgdVals_Ionic { get; }

	/// <summary>
	/// 1d  background corrected profile data - Ionic.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistBckgdCorrectedVals_Ionic { get; }

	/// <summary>
	/// 1d profile error data - Ionic.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedSigmaVals_Ionic { get; }

	/// <summary>
	/// 1d profile background corrected error data - Ionic.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedBckgdCorrectedSigmaVals_Ionic { get; }

	/// <summary>
	/// 1d profile count data - Ionic.  2D unsigned int array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<uint> DistributedCounts_Ionic { get; }

	/// <summary>
	/// 1d profile total count data - Ionic.  1D unsigned int array [Bin] 
	/// </summary>
	ReadOnlyMemory<uint> DistributedSumCountsInBin_Ionic { get; }

	/// <summary>
	/// 1d concentration profile data - Decomposed.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedYVals_Decomp { get; }

	/// <summary>
	/// 1d profile background data w/positivity constraint - Decomposed.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedBckgdVals_WPositivity_Decomp { get; }

	/// <summary>
	/// 1d background corrected w/positivity constraint profile data - Decomp.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistBckgdCorrectedVals_WPositivity_Decomp { get; }

	/// <summary>
	/// 1d profile background data - Decomposed.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedBckgdVals_Decomp { get; }

	/// <summary>
	/// 1d background corrected profile data - Decomp.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistBckgdCorrectedVals_Decomp { get; }

	/// <summary>
	/// 1d profile error data - Decomposed.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedSigmaVals_Decomp { get; }

	/// <summary>
	/// 1d profile background corrected error data - Decomposed.  2D double array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<double> DistributedBckgdCorrectedSigmaVals_Decomp { get; }

	/// <summary>
	/// 1d profile count data - Ionic.  2D unsigned int array [IonType, Bin] 
	/// </summary>
	ReadOnlyMemory2D<uint> DistributedCounts_Decomp { get; }

	/// <summary>
	/// 1d profile total count data - Ionic.  1D unsigned int array [Bin] 
	/// </summary>
	ReadOnlyMemory<uint> DistributedSumCountsInBin_Decomp { get; }


	/// <summary>
	/// Return Composition1DData x data (nm).  1D double array [Bin] 
	/// </summary>
	ReadOnlyMemory<double> XValues { get; }

	/// <summary>
	/// Return Composition1DData ionic count data (ions).  1D int array [Bin] 
	/// </summary>
	ReadOnlyMemory<int> BinIonCounts { get; }

	/// <summary>
	/// Return Composition1DData ionic count data (ions).  1D int array [Bin] 
	/// </summary>
	ReadOnlyMemory<double> BackgroundBinIonCounts { get; }

	bool HasBackground { get; }

	double BinWidth { get; }
}
