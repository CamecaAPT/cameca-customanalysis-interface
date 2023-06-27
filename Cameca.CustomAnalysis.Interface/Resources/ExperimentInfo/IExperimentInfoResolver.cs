namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Wrapper container for <see cref="IExperimentInfo"/>
/// </summary>
/// <remarks>
/// All experiment comes from the same source, soe instead of checking each property if they exists,
/// instead the entire object of resolved experiment information is returned or the object is null
/// if no info could be found (missing experiment file, likely due to pure reconstruction file import).
/// <br/>
/// All information in the <see cref="IExperimentInfo"/> object comes from the same source and is therefore
/// all resolved at once, and this source (experiment file) is almost guaranteed to never change. It likely
/// will only be different for subsequent calls if the file is found or goes missing at runtime in unusual
/// circumstances. The operation to resolve is also relatively expensive, so this makes the returned
/// <see cref="IExperimentInfo"/> a strong candidate to be cached.
/// <br/>
/// To avoid a rare situation where this data may no longer be valid but the information is already cached,
/// a <see cref="Refresh"/> method is provided to force the underlying object to be rebuilt.
/// In cases where there is an expectation that the experiment information may change or become available
/// where it was not before, such as if moving around RHIT or HITS files, then first call Refresh before
/// accessing the <see cref="ExperimentInfo"/> property.
/// </remarks>
public interface IExperimentInfoResolver
{
	string? ExperimentFileName { get; }
	IExperimentInfo? ExperimentInfo { get; }
	void Refresh();
}
