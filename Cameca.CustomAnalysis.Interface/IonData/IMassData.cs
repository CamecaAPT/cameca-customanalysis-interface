using System;

namespace Cameca.CustomAnalysis.Interface.IonData
{
	public interface IMassData
	{
		long IonCount();
		void IterateValues(Action<float> func);
	}
}
