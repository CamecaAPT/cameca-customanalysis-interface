using System;
using System.IO;

namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Builder for creating APT files
/// </summary>
public interface IAptFileBuilder : IDisposable
{
	/// <summary>
	/// Get or set the original file name field of the APT file header
	/// </summary>
	/// <remarks>
	/// If null, an attempt to resolve the file name will be made.
	/// If <see cref="Write"/> is called with a <see cref="FileStream"/> instance, the <see cref="FileStream.Name"/> value will be used,
	/// else the value will be left as an empty string.
	/// </remarks>
	string? OriginalFileName { get; set; }

	/// <summary>
	/// The number of ions in the APT file
	/// </summary>
	/// <remarks>
	/// If null, the value will be resolve from the (matching) length of the required Position and Mass sections.
	/// If this value does not match the Position and Mass sections lengths on write, an exception will be thrown.
	/// If set before any calls to <see cref="AddSection"/>, the underlying implementation may use this value as a
	/// hint for the created the file size to increase performance in writing basic APT files.
	/// </remarks>
	ulong? IonCount { get; set; }

	/// <summary>
	/// Adds a section to the APT file
	/// </summary>
	/// <param name="sectionType"></param>
	/// <param name="relationType"></param>
	/// <param name="recordType"></param>
	/// <param name="datatype"></param>
	/// <param name="dataTypeSize">Size in bits</param>
	/// <param name="recordSize">Total record size in bytes</param>
	/// <param name="unit"></param>
	/// <param name="extraData"></param>
	/// <param name="sectionData"></param>
	void AddSection(
		string sectionType,
		RelationType relationType,
		RecordType recordType,
		RecordDataType datatype,
		int dataTypeSize,
		int recordSize,
		string? unit,
		ReadOnlyMemory<byte>? extraData,
		ReadOnlyMemory<byte> sectionData);

	/// <summary>
	/// Writes the APT file to the given stream
	/// </summary>
	/// <remarks>
	/// The following requirements must be met or <see cref="FileFormatException"/> will be thrown:
	/// <list type="bullet">
	/// <item>
	/// A section with type "Position" is present.
	/// Relationship type must be <see cref="RelationType.OneToOne"/>.
	/// Record type must be <see cref="RecordType.Fixed"/>.
	/// Record data type must be <see cref="RecordDataType.Float"/>.
	/// Data type size must be 32 (single precision).
	/// Record size must be 12 bytes (3 * 4 byte single precision floating point values).
	/// </item>
	/// <item>
	/// A section with type "Mass" is present.
	/// Relationship type must be <see cref="RelationType.OneToOne"/>.
	/// Record type must be <see cref="RecordType.Fixed"/>.
	/// Record data type must be <see cref="RecordDataType.Float"/>.
	/// Data type size must be 32 (single precision).
	/// Record size must be 4 bytes (1 * 4 byte single precision floating point value).
	/// </item>
	/// <item>
	/// The record count of all sections with <see cref="RelationType.OneToOne"/> must be equal.
	/// If <see cref="IonCount"/> is set, it must also match this value.
	/// </item>
	/// </list>
	/// If <see cref="OriginalFileName"/> was not set and the <paramref name="stream"/> derives from <see cref="FileStream"/>,
	/// then <see cref="FileStream.Name"/> will be used as the original file name value for the APT file header.
	/// </remarks>
	/// <param name="stream"></param>
	/// <exception cref="FileFormatException">
	/// The information to build the APT file is invalid or internally inconsistent.
	/// </exception>
	void Write(Stream stream);
}
