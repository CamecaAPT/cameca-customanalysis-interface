namespace Cameca.CustomAnalysis.Interface;

public interface IExperimentInfo
{
	double AnalysisPressure { get; }
	string ApertureName { get; }
	int AtomProbeId { get; }
	string AtomProbeName { get; }
	string CalibrationFileName { get; }
	string Comments { get; }
	double DeltaTOFCorrSigma { get; }
	/// <summary>Detection efficiency as a fraction of evaporated ions</summary>
	double DetectorEfficiency { get; }
	int ElapsedTimeSec { get; }
	double FlightPath { get; }
	string HitFindingVersion { get; }
	InvizoBeamMode InvizoBeamMode { get; }
	InstrumentModel InstrumentModelNumber { get; }
	LaserBand LaserBandNum { get; }
	float LaserEnergyNormalization { get; }
	LaserPowerRange LaserPowerRange { get; }
	string LasRootVersion { get; }
	double LastRunLaserEnergyPJ { get; }
	double LastRunVoltage { get; }
	string LasVersion { get; }
	double MaxApertureAmplitude { get; }
	double McpEfficiency { get; }
	double MeshEfficiency { get; }
	string Name { get; }
	string ProjectName { get; }
	double PulseFrequency { get; }
	string Results { get; }
	string RunEndReason { get; }
	int RunNumber { get; }
	string SpecimenCondition { get; }
	string SpecimenName { get; }
	float SpecimenTemperature { get; }
	string StartDate { get; }
	string StartTime { get; }
	int StreamVersion { get; }
	double T0Estimate { get; }
	double TargetPulseFraction { get; }
	AquisitionMode UserAcqMode { get; }
}
