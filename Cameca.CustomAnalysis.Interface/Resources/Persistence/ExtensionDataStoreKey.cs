using System;

namespace Cameca.CustomAnalysis.Interface;

public class ExtensionDataStoreKey : IExtensionDataStoreKey
{
	public string Name { get; }

	public Version Version { get; }

	public ExtensionDataStoreKey(string name, Version version)
	{
		Name = name;
		Version = version;
	}
}
