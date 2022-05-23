using System;
using System.ComponentModel;
using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public interface IRenderData : INotifyPropertyChanged, IDisposable
{
	string Name { get; set; }
	bool IsVisible { get; set; }
	bool IsLegendVisible { get; set; }
	bool IsHitTestVisible { get; set; }
	Matrix4x4 Transform { get; set; }
	bool IsBoundsVisible { get; set; }
}
