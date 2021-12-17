namespace Cameca.CustomAnalysis.Interface.IonData
{
	public interface IAptSectionInfo
	{
		uint HeaderSize { get; }
		uint HeaderVersion { get; }
		uint SectionVersion { get; }
		SectionRelType RelationshipType { get; }
		SectionRecordType RecordType { get; }
		SectionRecordDataType RecordDataType { get; }
		uint DataTypeSizeBits { get; }
		uint RecordSizeBytes { get; }
		string Unit { get; }
		ulong RecordCount { get; }
		ulong ByteCount { get; }
		byte[] ExtraData { get; }
	}
}
