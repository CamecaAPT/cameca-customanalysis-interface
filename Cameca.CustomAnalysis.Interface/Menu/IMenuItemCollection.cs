using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface IMenuItemCollection : IMenuItemBase
{
    string Header { get; }
    IReadOnlyCollection<IMenuItemBase> ItemCollection { get; }
}