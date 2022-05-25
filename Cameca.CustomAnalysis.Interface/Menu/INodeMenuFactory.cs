using System.Collections.Generic;

namespace Cameca.CustomAnalysis.Interface;

public interface INodeMenuFactory
{
	IEnumerable<IMenuItem> ContextMenuItems { get; set; }
}
