using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface.View
{
	/// <summary>
	/// View Builder for custom analyzes.
	/// </summary>
	public interface IViewBuilder
	{
		/// <summary>
		/// Adds the table.
		/// </summary>
		/// <param name="title">The title.</param>
		/// <param name="content">The content.</param>
		void AddTable(string title, IEnumerable<object> content);
		/// <summary>
		/// Adds the text.
		/// </summary>
		/// <param name="title">The title.</param>
		/// <param name="content">The content.</param>
		void AddText(string title, string content);

		/// <summary>
		/// Adds the Chart2D.
		/// </summary>
		/// <param name="title">The tab title.</param>
		/// <param name="titleX">The title x.</param>
		/// <param name="titleY">The title y.</param>
		/// <returns>IChart2D instance.</returns>
		IChart2D AddChart2D(string title = "Chart2D", string titleX = "X", string titleY = "Y");

		/// <summary>
		/// Adds the chart3 d.
		/// </summary>
		/// <param name="title">The tab title.</param>
		/// <returns>IChart3D instance.</returns>
		IChart3D AddChart3D(string title);

		/// <summary>
		/// Adds the histogram2 d.
		/// </summary>
		/// <param name="histogram2DContainer">The histogram2 d container.</param>
		/// <param name="colorMap">The color map.</param>
		/// <param name="title">The title.</param>
		/// <param name="titleX">The x-axis title.</param>
		/// <param name="titleY">The y-axis title.</param>
		void AddHistogram2D(IHistogram2DContext histogram2DContext, string title, string titleX = "X", string titleY = "Y", ColorMap? colorMap = null);
	}
}
