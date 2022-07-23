using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeActivatedEvent : PubSubEvent<NodeActivatedEventArgs> { }

public class NodeActivatedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeActivatedEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeActivatedEventExtensions
{
	public static void PublishNodeRemoved(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeActivatedEvent>()
			.Publish(new NodeActivatedEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeRemoved(
		this IEventAggregator eventAggregator,
		Action<NodeActivatedEventArgs> action,
		Predicate<NodeActivatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeActivatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
