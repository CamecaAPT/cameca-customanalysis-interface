using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class NodeRemovingEvent : PubSubEvent<NodeRemovingEventArgs> { }

public class NodeRemovingEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeRemovingEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeRemovingEventExtensions
{
	public static void PublishNodeRemoving(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeRemovingEvent>()
			.Publish(new NodeRemovingEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeRemoving(
		this IEventAggregator eventAggregator,
		Action<NodeRemovingEventArgs> action,
		Predicate<NodeRemovingEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeRemovingEvent>()
			.Subscribe(action, filter: filter);
	}
}
