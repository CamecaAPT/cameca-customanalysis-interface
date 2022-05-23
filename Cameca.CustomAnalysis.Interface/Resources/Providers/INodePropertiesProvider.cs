using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodePropertiesProvider
{
    INodeProperties? Resolve(Guid nodeId);
}