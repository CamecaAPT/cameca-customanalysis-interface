using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeAddedEvent : PubSubEvent<NodeAddedEventArgs> { }

public class NodeAddedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public EventTrigger Trigger { get; }

	public NodeAddedEventArgs(Guid analysisNodeId, EventTrigger eventTrigger)
	{
		NodeId = analysisNodeId;
		Trigger = eventTrigger;
	}
}

public static class NodeAddedEventExtensions
{
	public static void PublishNodeAdded(
		this IEventAggregator eventAggregator,
		Guid nodeId,
		EventTrigger eventTrigger)
	{
		eventAggregator
			.GetEvent<NodeAddedEvent>()
			.Publish(new NodeAddedEventArgs(nodeId, eventTrigger));
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
