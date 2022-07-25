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
	public static void PublishNodeInteracted(
		this IEventAggregator eventAggregator,
		Guid nodeId,
		InteractionType interaction)
	{
		eventAggregator
			.GetEvent<NodeInteractedEvent>()
			.Publish(new NodeInteractedEventArgs(nodeId, interaction));
	}

	public static SubscriptionToken SubscribeNodeInteracted(
		this IEventAggregator eventAggregator,
		Action<NodeInteractedEventArgs> action,
		Predicate<NodeInteractedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeInteractedEvent>()
			.Subscribe(action, filter: filter);
	}
}