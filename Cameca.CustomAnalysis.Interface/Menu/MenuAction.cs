using System;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public class MenuAction : IMenuItem
{
    public string Caption { get; }
    public ImageSource? Icon { get; }
    public Action Action { get; }

    public MenuAction(string caption, Action action, ImageSource? icon = null)
    {
	    Caption = caption;
	    Icon = icon;
	    Action = action;
    }
}
