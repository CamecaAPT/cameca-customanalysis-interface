using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IElementDataSet
{
	/// <summary>
	/// Element data set ID.
	/// </summary>
	/// <remarks>
	/// This is only unique per database. If persisting in a location that could move between databases,
	/// this may not be reliable (e.g. a file that is exported and imported elsewhere).
	/// </remarks>
	public int Id { get; }
	public string Name { get; }
	public string? Comment { get; }
	/// <summary>
	/// Default element data set.
	/// </summary>
	/// <remarks>
	/// This is 
	/// </remarks>
	public bool IsDefault { get; }
	public IReadOnlyCollection<IElement> Elements { get; }
}
