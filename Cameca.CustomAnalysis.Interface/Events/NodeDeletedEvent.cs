using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class NodeDeletedEvent : PubSubEvent<NodeDeletedEventArgs> { }

public class NodeDeletedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeDeletedEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeDeletedEventExtensions
{
	public static void PublishNodeDeleted(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeDeletedEvent>()
			.Publish(new NodeDeletedEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeDeleted(
		this IEventAggregator eventAggregator,
		Action<NodeDeletedEventArgs> action,
		Predicate<NodeDeletedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeDeletedEvent>()
			.Subscribe(action, filter: filter);
	}
}
