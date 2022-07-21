using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IReconstructionSectionsProvider
{
	IReconstructionSections? Resolve(Guid nodeId);
}
