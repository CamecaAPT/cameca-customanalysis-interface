using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public class ColorMapEditor : Control
{
	public static readonly Color BottomColorDefault = Colors.Black;
	public static readonly Color NanColorDefault = Colors.Black;
	public static readonly Color OutOfRangeBottomColorDefault = Colors.Black;
	public static readonly Color OutOfRangeTopColorDefault = Colors.Black;
	public static readonly Color TopColorDefault = Colors.Black;
	public const float MinValueDefault = 0f;
	public const float MaxValueDefault = 0f;

	public static readonly DependencyProperty BottomColorProperty = DependencyProperty.Register(
		nameof(BottomColor), typeof(Color), typeof(ColorMapEditor), new FrameworkPropertyMetadata(BottomColorDefault, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
		{
			DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
		});

	public Color BottomColor
	{
		get => (Color)GetValue(BottomColorProperty);
		set => SetValue(BottomColorProperty, value);
	}

	public static readonly DependencyProperty NanColorProperty = DependencyProperty.Register(
		nameof(NanColor), typeof(Color), typeof(ColorMapEditor), new FrameworkPropertyMetadata(NanColorDefault, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
		{
			DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
		});

	public Color NanColor
	{
		get => (Color)GetValue(NanColorProperty);
		set => SetValue(NanColorProperty, value);
	}

	public static readonly DependencyProperty OutOfRangeBottomColorProperty = DependencyProperty.Register(
		nameof(OutOfRangeBottomColor), typeof(Color), typeof(ColorMapEditor), new FrameworkPropertyMetadata(OutOfRangeBottomColorDefault, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
		{
			DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
		});

	public Color OutOfRangeBottomColor
	{
		get => (Color)GetValue(OutOfRangeBottomColorProperty);
		set => SetValue(OutOfRangeBottomColorProperty, value);
	}

	public static readonly DependencyProperty OutOfRangeTopColorProperty = DependencyProperty.Register(
		nameof(OutOfRangeTopColor), typeof(Color), typeof(ColorMapEditor), new FrameworkPropertyMetadata(OutOfRangeTopColorDefault, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
		{
			DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
		});

	public Color OutOfRangeTopColor
	{
		get => (Color)GetValue(OutOfRangeTopColorProperty);
		set => SetValue(OutOfRangeTopColorProperty, value);
	}

	public static readonly DependencyProperty TopColorProperty = DependencyProperty.Register(
		nameof(TopColor), typeof(Color), typeof(ColorMapEditor), new FrameworkPropertyMetadata(TopColorDefault, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
		{
			DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
		});

	public Color TopColor
	{
		get => (Color)GetValue(TopColorProperty);
		set => SetValue(TopColorProperty, value);
	}

	public static readonly DependencyProperty ColorStopsProperty = DependencyProperty.Register(
		nameof(ColorStops), typeof(IEnumerable<IColorStop>), typeof(ColorMapEditor), new FrameworkPropertyMetadata(Enumerable.Empty<IColorStop>(), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
		{
			DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
		});

	public IEnumerable<IColorStop> ColorStops
	{
		get => (IEnumerable<IColorStop>)GetValue(ColorStopsProperty);
		set => SetValue(ColorStopsProperty, value);
	}

	public static readonly DependencyProperty MinValueProperty = DependencyProperty.Register(
		nameof(MinValue), typeof(float), typeof(ColorMapEditor), new FrameworkPropertyMetadata(MinValueDefault));

	public float MinValue
	{
		get => (float)GetValue(MinValueProperty);
		set => SetValue(MinValueProperty, value);
	}

	public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register(
		nameof(MaxValue), typeof(float), typeof(ColorMapEditor), new FrameworkPropertyMetadata(MaxValueDefault));

	public float MaxValue
	{
		get => (float)GetValue(MaxValueProperty);
		set => SetValue(MaxValueProperty, value);
	}

	public static readonly DependencyProperty ValueLabelProperty = DependencyProperty.Register(
		nameof(ValueLabel), typeof(string), typeof(ColorMapEditor), new FrameworkPropertyMetadata(null));

	public string? ValueLabel
	{
		get => (string)GetValue(ValueLabelProperty);
		set => SetValue(ValueLabelProperty, value);
	}
}
