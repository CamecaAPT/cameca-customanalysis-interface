using System;
using System.Numerics;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface ISpheresRenderData : IPointsRenderData
{
	int Resolution { get; set; }
	float Radius { get; set; }
}
