using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IExtensionDataStoreKey
{
    string Name { get; }
    Version Version { get; }
}