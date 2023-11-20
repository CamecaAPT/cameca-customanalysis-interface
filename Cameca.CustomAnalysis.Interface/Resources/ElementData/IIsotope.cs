namespace Cameca.CustomAnalysis.Interface;

public interface IIsotope
{
	double Abundance { get; }
	double Mass { get; }
	int MassNumber { get; }
}
