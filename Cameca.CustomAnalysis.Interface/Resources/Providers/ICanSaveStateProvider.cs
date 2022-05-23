using System;

namespace Cameca.CustomAnalysis.Interface;

public interface ICanSaveStateProvider
{
    ICanSaveState? Resolve(Guid nodeId);
}