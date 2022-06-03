using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeInfo
{
	string Name { get; }
	string Title { get; }
	string TypeId { get; }
	ImageSource? Icon { get; }
	Guid? Parent { get; }
	IEnumerable<Guid> Children { get; }
}
