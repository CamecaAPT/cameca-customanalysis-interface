using System;

namespace Cameca.CustomAnalysis.Interface;

public static class IonDataSectionName
{
	/// <summary>
	/// [<see cref="float"/>] Ambient Temperature (C)
	/// </summary>
	public const string AmbientTemperature = "AmbTemp";

	/// <summary>
	/// [<see cref="float"/>] Apex (nm)
	/// </summary>
	public const string ApexZ = "zApex";

	/// <summary>
	/// [<see cref="float"/>] Corrected Time of Flight (ns)
	/// </summary>
	public const string CorrectedTimeOfFlight = "tofc";

	/// <summary>
	/// [<see cref="float"/>] Detection Rate (%/100)
	/// </summary>
	public const string DetectionRate = "erate";

	/// <summary>
	/// [<see cref="System.Numerics.Vector2"/>] Detector Coordinates (mm)
	/// </summary>
	public const string DetectorCoordinates = "Detector Coordinates";

	/// <summary>
	/// [<see cref="float"/>] Detector X (mm)
	/// </summary>
	public const string DetectorX = "XDet_mm";

	/// <summary>
	/// [<see cref="float"/>] Detector Y (mm)
	/// </summary>
	public const string DetectorY = "YDet_mm";

	/// <summary>
	/// [<see cref="float"/>] Elapsed Time (s)
	/// </summary>
	public const string ElapsedTime = "tElapsed";

	/// <summary>
	/// [<see cref="long"/>] Event # / 'Z'
	/// </summary>
	public const string EventNumber = "z";

	/// <summary>
	/// [<see cref="ulong"/>] FEC Count
	/// </summary>
	public const string FractureGuard = "FractureGuard";

	[Obsolete("Not an available reconstruction section and not created by AP Suite. Ignore inclusion in APT File Format Known Specific Sections.")]
	public const string HitType = "Hit Type";

	/// <summary>
	/// [<see cref="byte"/>] A single byte integer encoding the type assigned to an ion.
	/// </summary>
	/// <remarks>
	/// Guaranteed to correspond to can be used to index into <see cref="IIonData.Ions"/> to retrieve detailed ion information.
	/// A value of <c>255</c> encodes an ion that has had no ion type assigned.
	/// </remarks>
	public const string IonType = "Ion Type";

	/// <summary>
	/// [<see cref="int"/>] Laser Position X (µm)
	/// </summary>
	public const string LaserPositionX = "laserx";

	/// <summary>
	/// [<see cref="int"/>] Laser Position Y (µm)
	/// </summary>
	public const string LaserPositionY = "lasery";

	/// <summary>
	/// [<see cref="int"/>] Laser Position Z (µm)
	/// </summary>
	public const string LaserPositionZ = "laserz";

	/// <summary>
	/// [<see cref="float"/>] Laser Pulse Energy (nJ)
	/// </summary>
	public const string LaserPower = "laserpower";

	/// <summary>
	/// [<see cref="float"/>] Mapped X Angle (deg)
	/// </summary>
	public const string MappedXAngle = "mappedXAngle";

	/// <summary>
	/// [<see cref="float"/>] Mapped Y Angle (deg)
	/// </summary>
	public const string MappedYAngle = "mappedYAngle";

	/// <summary>
	/// [<see cref="float"/>] Mass to Charge State Ratio (Da)
	/// </summary>
	public const string Mass = "Mass";

	/// <summary>
	/// [<see cref="int"/>] Representation of Ions Per Pulse
	/// </summary>
	/// <remarks>
	/// Contains the total number of recorded ion events for for a given pulse.
	/// Normally one, but for a sequence of records for a pulse with multiple recorded ions,
	/// the first ion record will have the total number of ions measures in that pulse,
	/// while the remaining records for that pulse will have 0.
	/// </remarks>
	/// <example>
	/// For 5 sequential pulses, the following number of ions were recorded per pulse: { 1, 1, 2, 3, 1 }
	/// This gives a total of 8 ions recorded over the 5 pulses.
	/// This sections will record the following values for these 8 ion records: { 1, 1, 2, 0, 3, 0, 0, 1 }
	/// Note how the first ion of each group of multiply detected ions in a pulse records the total count,
	/// while subsequent ions in the same pulse are recorded as 0.
	/// </example>
	public const string Multiplicity = "Multiplicity";

	/// <summary>
	/// [<see cref="float"/>] Noise (ppm/ns)
	/// </summary>
	public const string Noise = "Noise";

	[Obsolete("Not an available reconstruction section and not created by AP Suite. Ignore inclusion in APT File Format Known Specific Sections.")]
	public const string Phase = "Phase";

	/// <summary>
	/// [<see cref="System.Numerics.Vector3"/>] Reconstructed Position (nm)
	/// </summary>
	public const string Position = "Position";

	/// <summary>
	/// [<see cref="float"/>] Pressure (torr)
	/// </summary>
	public const string Pressure = "Pres";

	/// <summary>
	/// [<see cref="float"/>] Pulse number
	/// </summary>
	/// <remarks>
	/// When using this value, be sure to also use <see cref="PulsePrecisionDelta"/>.
	/// To resolve a real pulse number, cast both to doubles and add together.
	/// <br/>
	/// <c>double realPulseNumber = (double)Pulse + (double)PulsePrecisionDelta</c>
	/// </remarks>
	public const string Pulse = "pulse";

	/// <summary>
	/// [<see cref="int"/>] Delta Pulse  is the number of pulses since the last event
	/// </summary>
	/// <remarks>Equivalent to EPOS section</remarks>
	public const string PulseDelta = "Pulse Delta";

	/// <summary>
	/// [<see cref="short"/>] Difference between float and double of pulse
	/// </summary>
	/// <remarks>
	/// A precision adjustment for pulse number
	/// </remarks>
	public const string PulsePrecisionDelta = "pulseDelta";

	/// <summary>
	/// [<see cref="float"/>] Pulse Frequency (Hz)
	/// </summary>
	public const string PulseFrequency = "freq";

	/// <summary>
	/// [<see cref="float"/>] Aperture Voltage (V)
	/// </summary>
	public const string PulseVoltage = "Pulse Voltage";

	/// <summary>
	/// [<see cref="float"/>] Raw Time of Flight (ns)
	/// </summary>
	public const string RawTimeOfFlight = "tof";

	/// <summary>
	/// [<see cref="float"/>] Reconstructed X (nm)
	/// </summary>
	public const string ReconstructedX = "xs";

	/// <summary>
	/// [<see cref="float"/>] Reconstructed Y (nm)
	/// </summary>
	public const string ReconstructedY = "ys";

	/// <summary>
	/// [<see cref="float"/>] Reconstructed Z (nm)
	/// </summary>
	public const string ReconstructedZ = "zs";

	/// <summary>
	/// [<see cref="float"/>] Reflectron Voltage (V)
	/// </summary>
	public const string ReflectronVoltage = "Vref";

	/// <summary>
	/// [<see cref="float"/>] Initial X Position of Simulated Ion
	/// </summary>
	public const string SimOrigX = "xorig";

	/// <summary>
	/// [<see cref="float"/>] Initial Y Position of Simulated Ion
	/// </summary>
	public const string SimOrigY = "yorig";

	/// <summary>
	/// [<see cref="float"/>] Initial Z Position of Simulated Ion
	/// </summary>
	public const string SimOrigZ = "zorig";

	/// <summary>
	/// [<see cref="ulong"/>] Time since last stage move (s)
	/// </summary>
	public const string StageMoveTime = "tstage";

	/// <summary>
	/// [<see cref="int"/>] Stage Position X (µm)
	/// </summary>
	public const string StagePositionX = "xstage";

	/// <summary>
	/// [<see cref="int"/>] Stage Position Y (µm)
	/// </summary>
	public const string StagePositionY = "ystage";

	/// <summary>
	/// [<see cref="int"/>] Stage Position Z (µm)
	/// </summary>
	public const string StagePositionZ = "zstage";

	/// <summary>
	/// [<see cref="float"/>] Target Detection Rate (%/100)
	/// </summary>
	public const string TargetDetectionRate = "TargetErate";

	/// <summary>
	/// [<see cref="float"/>] Target Flux (%/µm²)
	/// </summary>
	public const string TargetFlux = "TargetFlux";

	/// <summary>
	/// [<see cref="float"/>] Specimen Temperature (K)
	/// </summary>
	public const string Temp = "Temp";

	/// <summary>
	/// [<see cref="float"/>] T0 subtracted Raw Time of Flight (ns)" }
	/// </summary>
	public const string TimeOfFlight = "Time of Flight";

	/// <summary>
	/// [<see cref="float"/>] Tip Radius (nm)
	/// </summary>
	public const string TipRadius = "rTip";

	/// <summary>
	/// [<see cref="float"/>] Uniformity
	/// </summary>
	public const string Uniformity = "Uniformity";

	/// <summary>
	/// [<see cref="float"/>] Specimen Voltage (V)
	/// </summary>
	public const string Voltage = "Voltage";

	/// <summary>
	/// [<see cref="float"/>] Z Sphere Corr (nm)
	/// </summary>
	public const string ZSphereCorr = "zSphereCorr";
}
