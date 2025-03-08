using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.CustomAnalysis.Interface;

public class Table : Control
{
	public const bool AutoWidthDefault = false;
	public static readonly IEnumerable ItemsSourceDefault = Enumerable.Empty<object>();

	public static readonly DependencyProperty AutoWidthProperty = DependencyProperty.Register(
		nameof(AutoWidth), typeof(bool), typeof(Table), new FrameworkPropertyMetadata(AutoWidthDefault));

	public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
		nameof(ItemsSource), typeof(IEnumerable), typeof(Table), new FrameworkPropertyMetadata(ItemsSourceDefault));

	public bool AutoWidth
	{
		get => (bool)GetValue(AutoWidthProperty);
		set => SetValue(AutoWidthProperty, value);
	}

	public IEnumerable ItemsSource
	{
		get => (IEnumerable)GetValue(ItemsSourceProperty);
		set => SetValue(ItemsSourceProperty, value);
	}
}
