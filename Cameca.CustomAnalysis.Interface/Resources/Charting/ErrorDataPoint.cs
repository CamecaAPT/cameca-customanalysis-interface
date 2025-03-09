using System.Numerics;


namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Data point for <see cref="IErrorRenderData"/>
/// </summary>
public readonly struct ErrorDataPoint
{
	/// <summary>Base point for the error data</summary>
	public readonly Vector3 Point;
	/// <summary>Error offset added in the direction of the <see cref="IErrorRenderData.OffsetDirection"/> vector</summary>
	public readonly float Plus;
	/// <summary>Error offset subtracted in the direction of the <see cref="IErrorRenderData.OffsetDirection"/> vector</summary>
	public readonly float Minus;

	/// <inheritdoc cref="ErrorDataPoint"/>
	/// <param name="point"><inheritdoc cref="ErrorDataPoint.Point"/></param>
	/// <param name="plus"></param>
	/// <param name="minus"></param>
	public ErrorDataPoint(Vector3 point, float plus, float minus)
	{
		Point = point;
		Plus = plus;
		Minus = minus;
	}
}
