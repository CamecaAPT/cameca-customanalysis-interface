using System.Windows;

namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// <see cref="RoutedEventArgs"/> for synchronization or release of <see cref="Chart3D"/> view synchronization.
/// </summary>
public class Chart3DSyncRoutedEventArgs : RoutedEventArgs
{
	/// <summary>
	/// Target <see cref="Chart3D"/> to which to sync this chart. If <c>null</c>, sync to the main analysis chart if available.
	/// </summary>
	public Chart3D? SyncChart { get; }

	/// <inheritdoc cref="Chart3DSyncRoutedEventArgs"/>
	/// <param name="routedEvent">The routed event identifier for this instance of the System.Windows.RoutedEventArgs class.</param>
	/// <param name="syncRouted">Target <see cref="Chart3D"/> to which to sync this chart. If <c>null</c>, sync to the main analysis chart if available.</param>
	public Chart3DSyncRoutedEventArgs(RoutedEvent routedEvent, Chart3D? syncRouted) : base(routedEvent)
	{
		SyncChart = syncRouted;
	}
}
