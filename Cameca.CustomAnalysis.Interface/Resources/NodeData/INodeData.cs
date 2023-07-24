using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeData
{
	IEnumerable<Type> DataTypes { get; }

	Task<object?> GetData(Type dataType, IProgress<double>? progress = null, CancellationToken cancellationToken = default);
}
