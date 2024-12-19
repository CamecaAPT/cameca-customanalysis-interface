using System;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeDataFilter
{
	GetIndicesDelegate? FilterDelegate { get; set; }
	// Default implementations doesn't work well for read/write properties. This is more just a one time registration;
	// it barely benefits from having the get in the first place. Just seperatate out into a get and set method
	// See DefaultImplementationHelper for some mmore compatibiltity information
	GetIndicesDelegateSync? GetFilterDelegateSync()
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
	void SetFilterDelegateSync(GetIndicesDelegateSync? filterDelegateSync)
		=> throw DefaultImplementationHelper.RequiresAPSuiteUpdate();
	bool IsInverted { get; set; }
	string? FilterProgressMessage { get => null; set { } }
	void FilterDataChanged() { }
	[Obsolete("IMPORTANT! READ THIS! This property is not obsolete. Do not enable this if the filter delegate in any ways uses ion type information or resulting data will be wrong. This includes any use of Ion Type data section or counts per ion.")]
	bool AllowOverrideRanges { get => false; set { } }
}
