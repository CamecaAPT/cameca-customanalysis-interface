using System;
using System.Diagnostics.CodeAnalysis;
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
	/// If members are added to an interface, developers updating this library will have compile errors, which is not desirable for non-major version releases. This can be
	/// assisted using default interface implementations. This allows developers to implement the interface where needed, while default implementations can be used otherwise.
	/// To avoid compile time breaking chagnes, added interface members that can not be deletgated to other members safely (e.g. sync versions of exting async API), can
	/// instead throw this message. If the consuming extension code updates, this will not break compilation and no exception should be thrown as the API isn't being called.
	/// If it is called, then a newer version of AP Suite that implementes these methods will be requried, in which case the default implementation should not be used, as
	/// a real implementation should be available. If an extension updates this library, then it will likely not work with older AP Suite versions anyways, as presumably
	/// the library is updated to take advantage of some new feature.
	/// <br />
	/// Practically speaking, this really shouldn't be hit. It could be if an extension updates a minor version and uses it on a slightly older verision of AP Suite.
	/// The code should theoretically run, but calling new members from older software needs to be handled in some way. A warning to update AP Suite, which in this case
	/// presumably should exists, is appropriate.
	/// </remarks>
	/// <param name="caller"></param>
	/// <exception cref="NotImplementedException"></exception>
	public static Exception RequiresAPSuiteUpdate([CallerMemberName] string? caller = null)
	{
		return new NotImplementedException($"{caller} is not supported by this version of AP Suite. Update AP Suite to a newer version to continue using this extension.");
	}
}
