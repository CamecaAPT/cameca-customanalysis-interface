using System;

namespace Cameca.CustomAnalysis.Interface;

public readonly struct InterfaceSubgroupROI
{
	public readonly ReadOnlyMemory<GridGeneratedInterface> InterfaceMeshes;
	public readonly InterfaceGradientDirection GradientDirection;

	public InterfaceSubgroupROI(ReadOnlyMemory<GridGeneratedInterface> interfaceMeshes, InterfaceGradientDirection gradientDirection)
	{
		InterfaceMeshes = interfaceMeshes;
		GradientDirection = gradientDirection;
	}
}
