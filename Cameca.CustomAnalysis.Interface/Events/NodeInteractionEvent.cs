
using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public enum NodeInteractionType
{
	Unknown = 0,
	DoubleClick = 1,
}

public class NodeInteractionEvent : PubSubEvent<NodeInteractionEventArgs> { }

public class NodeInteractionEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; set; }

	public NodeInteractionType Interaction { get; }

	public NodeInteractionEventArgs(Guid analysisNodeId, NodeInteractionType interaction)
	{
		NodeId = analysisNodeId;
		Interaction = interaction;
	}
}

public static class NodeInteractionEventArgsExtensions
{
	public static void PublishNodeInteraction(
		this IEventAggregator eventAggregator,
		Guid instanceId,
		NodeInteractionType interaction)
	{
		eventAggregator
			.GetEvent<NodeInteractionEvent>()
			.Publish(new NodeInteractionEventArgs(instanceId, interaction));
	}

	public static SubscriptionToken SubscribeNodeInteraction(
		this IEventAggregator eventAggregator,
		Action<NodeInteractionEventArgs> action,
		Predicate<NodeInteractionEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeInteractionEvent>()
			.Subscribe(action, filter: filter);
	}
}
