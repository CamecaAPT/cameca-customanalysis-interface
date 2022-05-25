using System;
using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public class SubMenu : IMenuItem
{
    public string Caption { get; }
    public IReadOnlyCollection<IMenuItem> MenuItems { get; init; } = Array.Empty<IMenuItem>();

    public SubMenu(string caption)
    {
	    Caption = caption;
    }
}
