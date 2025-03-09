using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class NodeDeletingEvent : PubSubEvent<NodeDeletingEventArgs> { }

public class NodeDeletingEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeDeletingEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeDeletingEventExtensions
{
	public static void PublishNodeDeleting(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeDeletingEvent>()
			.Publish(new NodeDeletingEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeDeleting(
		this IEventAggregator eventAggregator,
		Action<NodeDeletingEventArgs> action,
		Predicate<NodeDeletingEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeDeletingEvent>()
			.Subscribe(action, filter: filter);
	}
}
