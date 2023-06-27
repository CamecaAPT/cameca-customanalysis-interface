namespace Cameca.CustomAnalysis.Interface;

public interface IExperimentInfo
{
	/// <summary>Detection efficiency as a fraction of evaporated ions</summary>
	double DetectorEfficiency { get; }
}
