using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IMassSpectrumRangeManagerProvider
{
	IMassSpectrumRangeManager? Resolve(Guid nodeId);
}
