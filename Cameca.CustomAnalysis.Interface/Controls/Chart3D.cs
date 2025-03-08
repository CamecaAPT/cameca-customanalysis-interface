using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.CustomAnalysis.Interface;

public class Chart3D : Control
{
	public const bool IsToolbarVisibleDefault = true;
	public const bool IsScaleBarVisibleDefault = true;
	public const bool IsAxisVisibleDefault = true;

	public static readonly RoutedEvent Chart3DSyncEvent = EventManager.RegisterRoutedEvent(
		name: nameof(Chart3DSync),
		routingStrategy: RoutingStrategy.Bubble,
		handlerType: typeof(Chart3DSyncRoutedEventHandler),
		ownerType: typeof(Chart3D));

	public event Chart3DSyncRoutedEventHandler Chart3DSync
	{
		add { AddHandler(Chart3DSyncEvent, value); }
		remove { RemoveHandler(Chart3DSyncEvent, value); }
	}

	public static readonly RoutedEvent Chart3DReleaseSyncEvent = EventManager.RegisterRoutedEvent(
		name: nameof(Chart3DReleaseSync),
		routingStrategy: RoutingStrategy.Bubble,
		handlerType: typeof(Chart3DSyncRoutedEventHandler),
		ownerType: typeof(Chart3D));

	public event Chart3DSyncRoutedEventHandler Chart3DReleaseSync
	{
		add { AddHandler(Chart3DReleaseSyncEvent, value); }
		remove { RemoveHandler(Chart3DReleaseSyncEvent, value); }
	}

	public void Sync(Chart3D? syncChart)
	{
		var routedEventArgs = new Chart3DSyncRoutedEventArgs(Chart3DSyncEvent, syncChart);
		RaiseEvent(routedEventArgs);
	}

	public void ReleaseSync(Chart3D? syncChart)
	{
		var routedEventArgs = new Chart3DSyncRoutedEventArgs(Chart3DReleaseSyncEvent, syncChart);
		RaiseEvent(routedEventArgs);
	}

	public static readonly IEnumerable DataSourceDefault = Enumerable.Empty<object>();

	public static readonly DependencyProperty DataSourceProperty = DependencyProperty.Register(
		nameof(DataSource), typeof(IEnumerable), typeof(Chart3D), new FrameworkPropertyMetadata(DataSourceDefault));

	public IEnumerable DataSource
	{
		get => (IEnumerable)GetValue(DataSourceProperty);
		set => SetValue(DataSourceProperty, value);
	}

	public static readonly DependencyProperty IsToolbarVisibleProperty = DependencyProperty.Register(
		nameof(IsToolbarVisible), typeof(bool), typeof(Chart3D), new FrameworkPropertyMetadata(IsToolbarVisibleDefault));

	public bool IsToolbarVisible
	{
		get => (bool)GetValue(IsToolbarVisibleProperty);
		set => SetValue(IsToolbarVisibleProperty, value);
	}

	public static readonly DependencyProperty IsScaleBarVisibleProperty = DependencyProperty.Register(
		nameof(IsScaleBarVisible), typeof(bool), typeof(Chart3D), new FrameworkPropertyMetadata(IsScaleBarVisibleDefault));

	public bool IsScaleBarVisible
	{
		get => (bool)GetValue(IsScaleBarVisibleProperty);
		set => SetValue(IsScaleBarVisibleProperty, value);
	}

	public static readonly DependencyProperty IsAxisVisibleProperty = DependencyProperty.Register(
		nameof(IsAxisVisible), typeof(bool), typeof(Chart3D), new FrameworkPropertyMetadata(IsAxisVisibleDefault));

	public bool IsAxisVisible
	{
		get => (bool)GetValue(IsAxisVisibleProperty);
		set => SetValue(IsAxisVisibleProperty, value);
	}
}
