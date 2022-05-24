using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeAfterCreatedEvent : PubSubEvent<NodeAfterCreatedEventArgs> { }

public class NodeAfterCreatedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeAfterCreatedEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeAfterCreatedEventExtensions
{
	public static void PublishNodeAfterCreated(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeAfterCreatedEvent>()
			.Publish(new NodeAfterCreatedEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeAfterCreated(
		this IEventAggregator eventAggregator,
		Action<NodeAfterCreatedEventArgs> action,
		Predicate<NodeAfterCreatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeAfterCreatedEvent>()
			.Subscribe(action, filter: filter);
	}
}

