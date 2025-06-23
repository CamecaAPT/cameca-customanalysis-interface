using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;


public struct PeakDecompositionMathResult
{
	public int val;
}

public struct PeakDecompositionMathParams
{
	public int input;
}

public interface IPeakDecompositionMathCalculator
{
	//
	// Summary:
	//     Exposes a function that performs peak decomposition math
	//     If, for whatever reason, an extension wishes to perform a custom version
	//     of the peak decomposition calculation, provided its own parameters as input
	//     for the quadratic equation solver, this is the component that does the math
	//     to deconvolve the peaks

	PeakDecompositionMathResult DoPeakDecompositionMathCalculation(PeakDecompositionMathParams p);
}

 
