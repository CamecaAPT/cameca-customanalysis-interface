using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeRemovedEvent : PubSubEvent<NodeRemovedEventArgs> { }

public class NodeRemovedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeRemovedEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeRemovedEventExtensions
{
	public static void PublishNodeRemoved(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeRemovedEvent>()
			.Publish(new NodeRemovedEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeRemoved(
		this IEventAggregator eventAggregator,
		Action<NodeRemovedEventArgs> action,
		Predicate<NodeRemovedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeRemovedEvent>()
			.Subscribe(action, filter: filter);
	}
}

