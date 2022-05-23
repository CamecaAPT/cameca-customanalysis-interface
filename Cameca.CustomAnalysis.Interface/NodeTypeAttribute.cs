using System;

namespace Cameca.CustomAnalysis.Interface;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public class NodeTypeAttribute : Attribute
{
	public NodeType NodeType { get; }

	public NodeTypeAttribute(NodeType nodeType)
	{
		NodeType = nodeType;
	}
}
