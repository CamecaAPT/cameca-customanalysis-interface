using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public class IonRangeDefinition
{
	public string? Name { get; init; }

	public double? Volume { get; init; }

	public IEnumerable<Range> Ranges { get; }

	public IonRangeDefinition(IEnumerable<Range> ranges, string? name = default, double? volume = default)
	{
		Ranges = ranges;
		Name = name;
		Volume = volume;
	}
}
