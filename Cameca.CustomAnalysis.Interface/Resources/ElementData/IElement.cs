using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IElement
{
	int AtomicNumber { get; }
	string Name { get; }
	/// <summary>
	/// Atomic symobol of the element.
	/// </summary>
	/// <remarks>
	/// Always one or two characters, with the first character capitalized and the possible second character lowercase.
	/// </remarks>
	/// <example>
	/// <ul>
	///		<li>H</li>
	///		<li>He</li>
	///		<li>Li</li>
	/// </ul>
	/// </example>
	string Symbol { get; }
	double MolarVolume { get; }
	double AtomicRadius { get; }
	/// <summary>
	/// The set of isotopes for this element.
	/// </summary>
	/// <remarks>
	/// For each instance, the sum of all <see cref="IIsotope.Abundance"/> values will sum to one.
	/// </remarks>
	public IReadOnlyCollection<IIsotope> Isotopes { get; }
}
