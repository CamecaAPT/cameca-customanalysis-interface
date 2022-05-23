using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeAddedEvent : PubSubEvent<NodeAddedEventArgs> { }

public class NodeAddedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeAddedEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeAddedEventExtensions
{
	public static void PublishNodeAdded(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeAddedEvent>()
			.Publish(new NodeAddedEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeAdded(
		this IEventAggregator eventAggregator,
		Action<NodeAddedEventArgs> action,
		Predicate<NodeAddedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeAddedEvent>()
			.Subscribe(action, filter: filter);
	}
}
