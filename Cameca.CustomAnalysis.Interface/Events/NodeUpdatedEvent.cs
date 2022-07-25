using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeUpdatedEvent : PubSubEvent<NodeUpdatedEventArgs> { }

public class NodeUpdatedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeUpdatedEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeUpdatedEventExtensions
{
	public static void PublishNodeUpdated(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeUpdatedEvent>()
			.Publish(new NodeUpdatedEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeUpdated(
		this IEventAggregator eventAggregator,
		Action<NodeUpdatedEventArgs> action,
		Predicate<NodeUpdatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeUpdatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
