namespace Cameca.CustomAnalysis.Interface.IonData
{
	public delegate void PositionIteratorDiscrete(float x, float y, float z);

	public interface IPositionData
	{
		float[,] GetExtents();
		float[,] Extents { get; }
		long IonCount();
		void IterateValues(PositionIteratorDiscrete func);
	}
}
