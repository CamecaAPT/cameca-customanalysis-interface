﻿namespace Cameca.CustomAnalysis.Interface;

public interface IColorMapFactory
{
	IColorMap CreateColorMap();
	IColorStop CreateColorStop();
	IColorMap GetPresetColorMap(ColorMapPreset preset);
}
