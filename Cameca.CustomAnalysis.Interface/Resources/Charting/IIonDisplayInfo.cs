using System;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonDisplayInfo
{
	[Obsolete($"Incorrectly returns same color for all unknown ions with unique names but no defined formula.", false)]
	Color GetColor(IonFormula formula);

	Color GetColor(IIonTypeInfo ionTypeInfo)
	{
#pragma warning disable CS0618
		return GetColor(ionTypeInfo.Formula);
#pragma warning restore CS0618
	}
}
