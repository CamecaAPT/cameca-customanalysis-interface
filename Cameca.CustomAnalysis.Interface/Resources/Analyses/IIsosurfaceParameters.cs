using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IIsosurfaceParameters
{
	IonRatio IonRatio { get; }
	ProfileType ProfileType { get; }
	bool AtomicDecomposed { get; }
	Color Color { get; }
	float Isovalue { get; }
	float IsovalueMin { get; }
	float IsovalueMax { get; }
	double SampleCountThreshold { get; }
	double ConfidenceSigma { get; }
	FillMissingType FillMissingType { get; }
}
