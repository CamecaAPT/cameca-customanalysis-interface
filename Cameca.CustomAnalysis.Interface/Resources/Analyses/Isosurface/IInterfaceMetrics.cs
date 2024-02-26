using System;
using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public interface IInterfaceMetrics
{
	int NumPolygons { get; }
	float SurfaceArea { get; }
	bool IsBoundedVolume { get; }
	bool NormalsPointIn { get; }
	int PolygonEdgesUnsharedCount { get; }
	float Volume { get; }
	VectorPlane PlaneVectors { get; }
	Vector3 Centroid { get; }
	Vector3 Extent { get; }
	Vector3 Center { get; }
	Matrix4x4 DataToNominalPlaneTransform { get; }
	int NumSamplesX { get; }
	int NumSamplesY { get; }
	ReadOnlyMemory<float> SampledGrid { get; }
	int GValid { get; }
	ReadOnlyMemory<Vector3> SampledCoordinates { get; }
	bool HasHoles { get; }
	ReadOnlyMemory<float> HealedSampledGrid { get; }
	int GValidHealed { get; }
	ReadOnlyMemory<Vector3> HealedSampledCoordinates { get; }
	double RoughnessSa { get; }
	double RoughnessSq { get; }
	double RoughnessSv { get; }
	double RoughnessSp { get; }
	double RoughnessSt { get; }
}