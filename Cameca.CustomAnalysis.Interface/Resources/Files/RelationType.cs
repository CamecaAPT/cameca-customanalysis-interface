namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Defines how the section data is related to the number of ions
/// </summary>
public enum RelationType
{
	/// <summary>Data relation is unknown</summary>
	/// <remarks>Generally this will be treated as <see cref="Unrelated"/></remarks>
	Unknown = 0,

	/// <summary>Each ion has one data record</summary>
	/// <remarks>Section size must be record size * total ion count</remarks>
	OneToOne = 1,

	/// <summary>Currently unsupported in AP Suite</summary>
	//Indexed = 2,

	/// <summary>Section data is unrelated to ion count</summary>
	/// <remarks>Section size is unrestricted</remarks>
	Unrelated = 3,

	/// <summary>Currently unsupported in AP Suite</summary>
	//OneToMany = 4,
}
