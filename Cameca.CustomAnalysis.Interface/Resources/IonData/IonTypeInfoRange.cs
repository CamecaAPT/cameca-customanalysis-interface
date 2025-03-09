using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public class IonTypeInfoRange : IIonTypeInfo
{
	public string Name { get; }

	public IonFormula Formula { get; }

	public double Volume { get; }

	public double Min { get; }

	public double Max { get; }

	public Color Color { get; }

	public IonTypeInfoRange(
		string name,
		IonFormula ionFormula,
		double volume,
		double min,
		double max,
		Color color)
	{
		Name = name;
		Formula = ionFormula;
		Volume = volume;
		Min = min;
		Max = max;
		Color = color;
	}
}
