using System;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface IMenuAction : IMenuItemBase
{
    string Header { get; }
    ImageSource? Icon { get; }
    Action Action { get; }
}