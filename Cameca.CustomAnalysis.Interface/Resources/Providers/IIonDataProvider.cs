using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IIonDataProvider
{
	IIonDataResolver? Resolve(Guid nodeId);
}