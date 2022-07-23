using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeCreatedEvent : PubSubEvent<NodeCreatedEventArgs> { }

public class NodeCreatedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public EventTrigger Trigger { get; }

	public byte[]? Data { get; }

	public NodeCreatedEventArgs(Guid analysisNodeId, EventTrigger eventTrigger, byte[]? data = null)
	{
		NodeId = analysisNodeId;
		Trigger = eventTrigger;
		Data = data;
	}
}

public static class NodeCreatedEventExtensions
{
	public static void PublishNodeCreated(
		this IEventAggregator eventAggregator,
		Guid nodeId,
		EventTrigger eventTrigger,
		byte[]? data = null)
	{
		eventAggregator
			.GetEvent<NodeCreatedEvent>()
			.Publish(new NodeCreatedEventArgs(nodeId, eventTrigger, data));
	}

	public static SubscriptionToken SubscribeNodeCreated(
		this IEventAggregator eventAggregator,
		Action<NodeCreatedEventArgs> action,
		Predicate<NodeCreatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeCreatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
