using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IIdProvider
{
    Guid Get(object item);
}