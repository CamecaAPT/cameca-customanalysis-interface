using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeData
{
	IEnumerable<Type> DataTypes { get; }

	Task<object?> GetData(Type dataType, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
	object? GetDataSync(Type dataType, IProgress<double>? progress = null, CancellationToken cancellationToken = default)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
}
