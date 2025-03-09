namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Defines the type of data stored in the section
/// </summary>
public enum RecordDataType
{
	/// <summary>Record data type is unknown</summary>
	/// <remarks>Will be treated as raw bytes</remarks>
	Unknown = 0,

	/// <summary>Signed integer</summary>
	/// <remarks>Must have data type size of 8, 16, 32, or 64, representing the common integer sizes in bits</remarks>
	Int = 1,

	/// <summary>Unsigned integer</summary>
	/// <remarks>Should have the same sizes as <see cref="Int"/>, and the special case with 8 should be the default for raw binary data</remarks>
	Uint = 2,

	/// <summary>Floating point number (IEEE 754)</summary>
	/// <remarks>Must have data type size of 32 or 64, representing single or double precision</remarks>
	Float = 3,

	/// <summary>Text string</summary>
	/// <remarks>Must have data type size of 8 or 16, representing UTF-8 or UTF-16 encoding respectfully</remarks>
	String = 4,

	/// <summary>Record data type is undefined or unknown</summary>
	/// <remarks>Will be treated as raw bytes</remarks>
	Other = 5,
}
