using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonDisplayInfo
{
	Color GetColor(IonFormula formula);
}
