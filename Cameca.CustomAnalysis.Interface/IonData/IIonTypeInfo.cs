using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface.IonData
{
	public interface IIonTypeInfo
	{
		byte GetOrAdd(IIonTypeInfoRecord ion);
		void Remove(byte index);
		int Count { get; }
		IReadOnlyList<IIonTypeInfoRecord> GetIons();
		IReadOnlyList<IIonTypeInfoRecord> Ions { get; }
	}
}
