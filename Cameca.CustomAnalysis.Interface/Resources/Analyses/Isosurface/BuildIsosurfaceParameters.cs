namespace Cameca.CustomAnalysis.Interface;

public sealed class BuildIsosurfaceParameters
{
	public const ProfileType DefaultProfileType = ProfileType.Concentration;
	public const bool DefaultAtomicDecomposed = false;

	public IonRatio IonRatio { get; }

	public ProfileType ProfileType { get; init; } = DefaultProfileType;

	/// <summary>
	/// Use complex ions if true, else decompose into component atoms if false
	/// </summary>
	public bool AtomicDecomposed { get; init; } = DefaultAtomicDecomposed;

	public BuildIsosurfaceParameters(IonRatio ionRatio)
	{
		IonRatio = ionRatio;
	}
}
