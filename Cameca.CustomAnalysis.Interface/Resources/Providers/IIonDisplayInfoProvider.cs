using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonDisplayInfoProvider
{
	IIonDisplayInfo? Resolve(Guid viewModelId);
}
