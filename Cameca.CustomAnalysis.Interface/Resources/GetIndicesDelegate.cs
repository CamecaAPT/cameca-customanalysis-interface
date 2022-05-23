using System;
using System.Collections.Generic;
using System.Threading;

namespace Cameca.CustomAnalysis.Interface;

public delegate IAsyncEnumerable<ReadOnlyMemory<ulong>> GetIndicesDelegate(IIonData ownerIonData, IProgress<double>? progress, CancellationToken token);