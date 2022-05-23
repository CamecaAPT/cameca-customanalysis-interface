using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeRequestDataUpdateEvent : PubSubEvent<NodeRequestDataUpdateEventArgs> { }

public class NodeRequestDataUpdateEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeRequestDataUpdateEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeRequestDataUpdateEventExtensions
{
	public static void PublishNodeRequestDataUpdate(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeRequestDataUpdateEvent>()
			.Publish(new NodeRequestDataUpdateEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeRequestDataUpdate(
		this IEventAggregator eventAggregator,
		Action<NodeRequestDataUpdateEventArgs> action,
		Predicate<NodeRequestDataUpdateEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeRequestDataUpdateEvent>()
			.Subscribe(action, filter: filter);
	}
}
