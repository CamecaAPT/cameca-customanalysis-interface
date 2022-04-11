using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface.CustomAnalysis;

/// <summary>
/// Interface for analysis tree node, used in custom analysis
/// </summary>
public interface IAnalysisTreeNode
{
    /// <summary>
    /// Parent node
    /// </summary>
    IAnalysisTreeNode Parent { get; }

    /// <summary>
    /// Child nodes
    /// </summary>
    IEnumerable<IAnalysisTreeNode> Children { get; }
}