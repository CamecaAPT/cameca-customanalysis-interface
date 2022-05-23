using System;

namespace Cameca.CustomAnalysis.Interface;

public readonly struct InterfaceSubgroupROI
{
    public readonly ReadOnlyMemory<IndexedTriangleArray> InterfaceMeshes;
    public readonly InterfaceGradientDirection GradientDirection;

    public InterfaceSubgroupROI(ReadOnlyMemory<IndexedTriangleArray> interfaceMeshes, InterfaceGradientDirection gradientDirection)
    {
        InterfaceMeshes = interfaceMeshes;
        GradientDirection = gradientDirection;
    }
}