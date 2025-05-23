﻿using System.Threading;
using System.Threading.Tasks;

namespace Cameca.CustomAnalysis.Interface;

public interface IExtensionDataStore
{
	Task<string?> Get(IExtensionDataStoreKey key, bool isUserScoped, CancellationToken cancellationToken);
	string? GetSync(IExtensionDataStoreKey key, bool isUserScoped, CancellationToken cancellationToken)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();

	Task<bool> Set(IExtensionDataStoreKey key, string value, bool isUserScoped, CancellationToken cancellationToken, bool createIfMissing = true);
	bool SetSync(IExtensionDataStoreKey key, string value, bool isUserScoped, CancellationToken cancellationToken, bool createIfMissing = true)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
}
