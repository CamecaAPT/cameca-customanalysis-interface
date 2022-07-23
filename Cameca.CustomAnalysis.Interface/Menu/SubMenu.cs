using System;
using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public class SubMenu : IMenuItem
{
	public string Caption { get; }

	public bool IsEnabled { get; }

	public IReadOnlyCollection<IMenuItem> MenuItems { get; init; } = Array.Empty<IMenuItem>();
	
    public string? ToolTip { get; }

	public SubMenu(string caption, bool isEnabled = true, string? toolTip = null)
    {
	    Caption = caption;
	    IsEnabled = isEnabled;
	    ToolTip = toolTip;
    }
}
