using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IInstanceProvider
{
	object? Resolve(Guid instanceId);
}
