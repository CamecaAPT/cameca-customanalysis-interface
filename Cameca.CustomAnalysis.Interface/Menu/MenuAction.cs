using System.Windows.Input;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public class MenuAction : IMenuItem
{
	public string Caption { get; }

	public ICommand Command { get; }

	public ImageSource? Icon { get; }

	public bool IsEnabled { get; }

	public string? ToolTip { get; }

	public MenuAction(string caption, ICommand command, ImageSource? icon = null, bool isEnabled = true, string? toolTip = null)
	{
		Caption = caption;
		Icon = icon;
		Command = command;
		IsEnabled = isEnabled;
		ToolTip = toolTip;
	}
}
