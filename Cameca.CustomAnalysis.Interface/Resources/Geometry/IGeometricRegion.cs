using System.Numerics;

namespace Cameca.CustomAnalysis.Interface;

public interface IGeometricRegion
{
	/// <summary>
	/// Defines if the defined region represents ions contained inside or outside the geometric shape.
	/// </summary>
	Containment Containment { get; }
	/// <summary>
	/// Defines the base shape used to define the region of interest.
	/// </summary>
	Shape Shape { get; }
	/// <summary>
	/// Scale, Rotation, Translation transformation matrix.
	/// Basic shape centered at origin (all dimensions unit vectors) has this
	/// applied Affine transformation to create resulting shape.
	/// <see cref="Matrix4x4.Decompose(Matrix4x4, out Vector3, out Quaternion, out Vector3)" />
	/// can be used to extract individual components or relevant information such as scale.
	/// </summary>
	Matrix4x4 SrtTransformation { get; }
}
