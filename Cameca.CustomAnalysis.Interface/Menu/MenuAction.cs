using System;
using System.Windows.Input;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public class MenuAction : IMenuItem
{
    public string Caption { get; }
    public ImageSource? Icon { get; }
    public ICommand Command { get; }

    public MenuAction(string caption, ICommand command, ImageSource? icon = null)
    {
	    Caption = caption;
	    Icon = icon;
	    Command = command;
    }
}
