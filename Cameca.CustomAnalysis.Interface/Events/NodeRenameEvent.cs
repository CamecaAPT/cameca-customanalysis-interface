using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeRenameEvent : PubSubEvent<NodeRenameEventArgs> { }

public class NodeRenameEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }
	public string Name { get; }

	public NodeRenameEventArgs(Guid analysisNodeId, string name)
	{
		NodeId = analysisNodeId;
		Name = name;
	}
}

public static class NodeRenameEventExtensions
{
	public static void PublishNodeRename(
		this IEventAggregator eventAggregator,
		Guid nodeId,
		string name)
	{
		eventAggregator
			.GetEvent<NodeRenameEvent>()
			.Publish(new NodeRenameEventArgs(nodeId, name));
	}

	public static SubscriptionToken SubscribeNodeRename(
		this IEventAggregator eventAggregator,
		Action<NodeRenameEventArgs> action,
		Predicate<NodeRenameEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeRenameEvent>()
			.Subscribe(action, filter: filter);
	}
}

