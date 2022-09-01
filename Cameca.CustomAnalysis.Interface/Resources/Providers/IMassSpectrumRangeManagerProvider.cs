using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IMassSpectrumRangeManagerProvider
{
	ICanSaveState? Resolve(Guid nodeId);
}
