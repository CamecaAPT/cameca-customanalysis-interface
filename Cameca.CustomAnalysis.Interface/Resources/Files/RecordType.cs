namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Defines the way records are written in the section
/// </summary>
public enum RecordType
{
	/// <summary>Record type is unknown</summary>
	/// <remarks>Will result in undefined behavior</remarks>
	Unknown = 0,

	/// <summary>Each record has a fixed length</summary>
	Fixed = 1,

	// <summary>Currently unsupported in AP Suite</summary>
	//Variable = 2,

	// <summary>Currently unsupported in AP Suite</summary>
	//List = 3,
}
