using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeSaveInterceptorProvider
{
    INodeSaveInterceptor? Resolve(Guid nodeId);
}