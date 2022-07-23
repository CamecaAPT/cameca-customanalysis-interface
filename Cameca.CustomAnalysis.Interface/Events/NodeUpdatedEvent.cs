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
	public static void PublishNodeSaved(
		this IEventAggregator eventAggregator,
		Guid analysisNodeId)
	{
		eventAggregator
			.GetEvent<NodeUpdatedEvent>()
			.Publish(new NodeUpdatedEventArgs(analysisNodeId));
	}

	public static SubscriptionToken SubscribeNodeSaved(
		this IEventAggregator eventAggregator,
		Action<NodeUpdatedEventArgs> action,
		Predicate<NodeUpdatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeUpdatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
