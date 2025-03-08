using System.Collections;
using System.Linq;
using System.Numerics;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.CustomAnalysis.Interface;

public class Chart2D : Control
{
	public static readonly IEnumerable DataSourceDefault = Enumerable.Empty<object>();
	public const bool IsLogScaleYDefault = false;
	public const bool IsLegendVisibleDefault = false;
	public const bool UseDefaultViewportResetBehaviorDefault = true;
	public const bool IsViewportUpdatesEnabledDefault = true;
	public const bool IsMouseDataCoordinatesEnabledDefault = false;
	public const Projection2D ProjectionDefault = Projection2D.XZ;
	public const bool IsToolbarVisibleDefault = true;

	public static readonly DependencyProperty DataSourceProperty = DependencyProperty.Register(
		nameof(DataSource), typeof(IEnumerable), typeof(Chart2D), new FrameworkPropertyMetadata(DataSourceDefault));

	public IEnumerable DataSource
	{
		get => (IEnumerable)GetValue(DataSourceProperty);
		set => SetValue(DataSourceProperty, value);
	}

	public static readonly DependencyProperty AxisXLabelProperty = DependencyProperty.Register(
		nameof(AxisXLabel), typeof(string), typeof(Chart2D), new FrameworkPropertyMetadata("X"));

	public string AxisXLabel
	{
		get => (string)GetValue(AxisXLabelProperty);
		set => SetValue(AxisXLabelProperty, value);
	}

	public static readonly DependencyProperty AxisYLabelProperty = DependencyProperty.Register(
		nameof(AxisYLabel), typeof(string), typeof(Chart2D), new FrameworkPropertyMetadata("Y"));

	public string AxisYLabel
	{
		get => (string)GetValue(AxisYLabelProperty);
		set => SetValue(AxisYLabelProperty, value);
	}

	public static readonly DependencyProperty IsLogScaleYProperty = DependencyProperty.Register(
		nameof(IsLogScaleY), typeof(bool), typeof(Chart2D), new FrameworkPropertyMetadata(IsLogScaleYDefault));

	public bool IsLogScaleY
	{
		get => (bool)GetValue(IsLogScaleYProperty);
		set => SetValue(IsLogScaleYProperty, value);
	}

	public static readonly DependencyProperty ChartPaddingProperty = DependencyProperty.Register(
		nameof(ChartPadding), typeof(Thickness), typeof(Chart2D), new FrameworkPropertyMetadata(default(Thickness)));

	public Thickness ChartPadding
	{
		get => (Thickness)GetValue(ChartPaddingProperty);
		set => SetValue(ChartPaddingProperty, value);
	}

	public static readonly DependencyProperty IsLegendVisibleProperty = DependencyProperty.Register(
		nameof(IsLegendVisible), typeof(bool), typeof(Chart2D), new FrameworkPropertyMetadata(IsLegendVisibleDefault));

	public bool IsLegendVisible
	{
		get => (bool)GetValue(IsLegendVisibleProperty);
		set => SetValue(IsLegendVisibleProperty, value);
	}

	public static readonly DependencyProperty UseDefaultViewportResetBehaviorProperty = DependencyProperty.Register(
		nameof(UseDefaultViewportResetBehavior), typeof(bool), typeof(Chart2D), new FrameworkPropertyMetadata(UseDefaultViewportResetBehaviorDefault));

	public bool UseDefaultViewportResetBehavior
	{
		get => (bool)GetValue(UseDefaultViewportResetBehaviorProperty);
		set => SetValue(UseDefaultViewportResetBehaviorProperty, value);
	}

	public static readonly DependencyProperty IsViewportUpdatesEnabledProperty = DependencyProperty.Register(
		nameof(IsViewportUpdatesEnabled), typeof(bool), typeof(Chart2D), new FrameworkPropertyMetadata(IsViewportUpdatesEnabledDefault));

	public bool IsViewportUpdatesEnabled
	{
		get => (bool)GetValue(IsViewportUpdatesEnabledProperty);
		set => SetValue(IsViewportUpdatesEnabledProperty, value);
	}

	public static readonly DependencyProperty ViewportLowerProperty = DependencyProperty.Register(
		nameof(ViewportLower), typeof(Vector2), typeof(Chart2D), new FrameworkPropertyMetadata() { BindsTwoWayByDefault = true, });

	public Vector2 ViewportLower
	{
		get => (Vector2)GetValue(ViewportLowerProperty);
		set => SetValue(ViewportLowerProperty, value);
	}

	public static readonly DependencyProperty ViewportUpperProperty = DependencyProperty.Register(
		nameof(ViewportUpper), typeof(Vector2), typeof(Chart2D), new FrameworkPropertyMetadata() { BindsTwoWayByDefault = true, });

	public Vector2 ViewportUpper
	{
		get => (Vector2)GetValue(ViewportUpperProperty);
		set => SetValue(ViewportUpperProperty, value);
	}

	public static readonly DependencyProperty IsMouseDataCoordinatesEnabledProperty = DependencyProperty.Register(
		nameof(IsMouseDataCoordinatesEnabled), typeof(bool), typeof(Chart2D), new FrameworkPropertyMetadata(IsMouseDataCoordinatesEnabledDefault));

	public bool IsMouseDataCoordinatesEnabled
	{
		get => (bool)GetValue(IsMouseDataCoordinatesEnabledProperty);
		set => SetValue(IsMouseDataCoordinatesEnabledProperty, value);
	}

	public static readonly DependencyProperty MouseDataCoordinatesProperty = DependencyProperty.Register(
		nameof(MouseDataCoordinates), typeof(Vector3), typeof(Chart2D), new FrameworkPropertyMetadata() { BindsTwoWayByDefault = true, });

	public Vector3 MouseDataCoordinates
	{
		get => (Vector3)GetValue(MouseDataCoordinatesProperty);
		set => SetValue(MouseDataCoordinatesProperty, value);
	}

	public static readonly DependencyProperty ProjectionProperty = DependencyProperty.Register(
		nameof(Projection), typeof(Projection2D), typeof(Chart2D), new FrameworkPropertyMetadata(ProjectionDefault));

	public Projection2D Projection
	{
		get => (Projection2D)GetValue(ProjectionProperty);
		set => SetValue(ProjectionProperty, value);
	}

	public static readonly DependencyProperty IsToolbarVisibleProperty = DependencyProperty.Register(
		nameof(IsToolbarVisible), typeof(bool), typeof(Chart2D), new FrameworkPropertyMetadata(IsToolbarVisibleDefault));

	public bool IsToolbarVisible
	{
		get => (bool)GetValue(IsToolbarVisibleProperty);
		set => SetValue(IsToolbarVisibleProperty, value);
	}
}
