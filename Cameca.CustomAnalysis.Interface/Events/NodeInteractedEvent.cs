using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeInteractedEvent : PubSubEvent<NodeInteractedEventArgs> { }

public class NodeInteractedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; set; }

	public InteractionType Interaction { get; }

	public NodeInteractedEventArgs(Guid analysisNodeId, InteractionType interaction)
	{
		NodeId = analysisNodeId;
		Interaction = interaction;
	}
}

public static class NodeInteractedEventArgsExtensions
{
	public static void PublishNodeInteraction(
		this IEventAggregator eventAggregator,
		Guid instanceId,
		InteractionType interaction)
	{
		eventAggregator
			.GetEvent<NodeInteractedEvent>()
			.Publish(new NodeInteractedEventArgs(instanceId, interaction));
	}

	public static SubscriptionToken SubscribeNodeInteraction(
		this IEventAggregator eventAggregator,
		Action<NodeInteractedEventArgs> action,
		Predicate<NodeInteractedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeInteractedEvent>()
			.Subscribe(action, filter: filter);
	}
}