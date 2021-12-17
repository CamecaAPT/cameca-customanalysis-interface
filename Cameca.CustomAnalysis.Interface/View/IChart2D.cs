using System.Collections.Generic;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface.View
{
	/// <summary>
	/// 2d chart interface for custom analysis view builder
	/// </summary>
	public interface IChart2D
	{
		/// <summary>
		/// Gets the title x.
		/// </summary>
		/// <value>
		/// The title x.
		/// </value>
		string XTitle { get; }

		/// <summary>
		/// Gets the title y.
		/// </summary>
		/// <value>
		/// The title y.
		/// </value>
		string YTitle { get; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is property grid visible.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance is property grid visible; otherwise, <c>false</c>.
		/// </value>
		bool IsPropertyGridVisible { get; set; }

		/// <summary>
		/// Adds the line.
		/// </summary>
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		/// <param name="color">The color.</param>
		/// <param name="name">The name.</param>
		/// <param name="thickness">The thickness.</param>
		/// <returns>Line object.</returns>
		void AddLine(float[] x, float[] y, Color color, string name = "Line", float thickness = 1);

		/// <summary>
		/// Adds the histogram.
		/// </summary>
		/// <param name="x">The x.</param>
		/// <param name="y">The y.</param>
		/// <param name="color">The color.</param>
		/// <param name="peakRanges">The peak ranges.</param>
		/// <param name="name">The name.</param>
		/// <param name="thickness">The thickness.</param>
		/// <returns>Histogram object.</returns>
		void AddHistogram(float[] x, float[] y, Color color, IEnumerable<PeakRange>? peakRanges = null, string name = "Histogram", float thickness = 1);
	}
}
