using System.Collections.Generic;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface.IonData
{
	public interface IIonTypeInfoRecord
	{
		string Name { get; }
		
		List<IElement> Formula { get; }
		
		Color? Color { get; }

		double Volume { get; }
	}
}
