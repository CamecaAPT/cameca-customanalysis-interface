using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataFilterInterceptorProvider
{
    INodeDataFilterInterceptor? Resolve(Guid nodeId);
}