using System;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface.CustomAnalysis
{
	/// <summary>
	/// Custom analysis description class
	/// </summary>
	public class CustomAnalysisDescription
	{
		/// <summary>
		/// Internal Id of the custom analysis (string)
		/// </summary>
		public string Id { get; }

		/// <summary>
		/// Display name (user visible) of the custom analysis
		/// </summary>
		public string DisplayName { get; }

		/// <summary>
		/// Comment property
		/// </summary>
		public string? Comment { get; }

		/// <summary>
		/// Icon for the custom analysis
		/// </summary>
		public ImageSource? Icon { get; }

		/// <summary>
		/// Version of the custom analysis
		/// </summary>
		public Version Version { get; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="displayName">Display name</param>
		/// <param name="version">Version</param>
		/// <param name="comment">Comment (optional)</param>
		/// <param name="icon">Icon (optional)</param>
		public CustomAnalysisDescription(string id, string displayName, Version version, string? comment = null, ImageSource? icon = null)
		{
			Id = id ?? throw new ArgumentNullException(nameof(id));
			DisplayName = displayName ?? throw new ArgumentNullException(nameof(displayName));
			Version = version ?? throw new ArgumentNullException(nameof(version));
			Comment = comment;
			Icon = icon;
		}
	}
}
