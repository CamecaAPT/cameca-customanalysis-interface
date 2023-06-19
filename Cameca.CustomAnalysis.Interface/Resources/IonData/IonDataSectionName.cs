namespace Cameca.CustomAnalysis.Interface;

public static class IonDataSectionName
{
	/// <summary>
	/// [<see cref="System.Numerics.Vector3"/>] Three single precision floats representing the reconstructed X, Y, and Z positions respectfully of an ion.
	/// </summary>
	public const string Position = "Position";

	/// <summary>
	/// [<see cref="float"/>] A single precision float representing the ion mass to charge ratio.
	/// </summary>
	public const string Mass = "Mass";

	/// <summary>
	/// [<see cref="byte"/>] A single byte integer encoding the type assigned to an ion.
	/// </summary>
	/// <remarks>
	/// Guaranteed to correspond to can be used to index into <see cref="IIonData.Ions"/> to retrieve detailed ion information.
	/// A value of <c>255</c> encodes an ion that has had no ion type assigned.
	/// </remarks>
	public const string IonType = "Ion Type";

	public const string TimeOfFlight = "Time of Flight";

	public const string Voltage = "Voltage";

	public const string PulseVoltage = "Pulse Voltage";

	public const string DetectorCoordinates = "Detector Coordinates";

	public const string PulseDelta = "Pulse Delta";

	public const string HitType = "Hit Type";

	public const string Phase = "Phase";

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
}
