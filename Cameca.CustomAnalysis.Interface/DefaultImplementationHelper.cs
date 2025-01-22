using System;
using System.Runtime.CompilerServices;

namespace Cameca.CustomAnalysis.Interface;

internal static class DefaultImplementationHelper
{
	/// <summary>
	/// Throw <see cref="NotImplementedException" /> with message indicating lack of support for this function
	/// </summary>
	/// <remarks>
	/// To best support extension compatibility, we try to minimize breaking changes to this library. Breaking changes can be both compile time for developers or at runtime.
	/// The latest versions of AP Suite should always implement or delegate all code in the latest version of this interface.
	/// If an older version of AP Suite that doesn't implement these methods attempts to run an extension that uses the newer features, then it will likely not work anyways,
	/// as presumably the extension uses the updated library to take advantage of some new feature.
	/// <br />
	/// Practically speaking, this really shouldn't be hit if users keep AP Suite updated. It could be if an extension updates a minor version and a slightly older verision
	/// of AP Suite is used to run it. Calling new members from older software needs to be handled in some way. A warning to update AP Suite, which in this case
	/// presumably should exists, is appropriate.
	/// </remarks>
	/// <param name="caller"></param>
	/// <exception cref="NotImplementedException"></exception>
	public static Exception RequiresAPSuiteUpdate([CallerMemberName] string? caller = null)
	{
		return new NotImplementedException($"{caller} is not supported by this version of AP Suite. Update AP Suite to a newer version to continue using this extension.");
	}
}
