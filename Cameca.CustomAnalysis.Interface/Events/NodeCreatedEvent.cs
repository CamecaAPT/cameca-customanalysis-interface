using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeCreatedEvent : PubSubEvent<NodeCreatedEventArgs> { }

public class NodeCreatedEventArgs : INodeTargetEvent, INodeInstantiatedEventArgs
{
	public Guid NodeId { get; }

	public NodeCreatedEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeCreatedEventExtensions
{
	public static void PublishNodeCreated(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeCreatedEvent>()
			.Publish(new NodeCreatedEventArgs(nodeId));
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

