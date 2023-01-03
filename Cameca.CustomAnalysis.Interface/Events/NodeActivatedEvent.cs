using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

[Obsolete($"Incorrect naming: Use {nameof(NodeRemovingEvent)}")]
public class NodeActivatedEvent : PubSubEvent<NodeActivatedEventArgs> { }

[Obsolete($"Incorrect naming: Use {nameof(NodeRemovingEventArgs)}")]
public class NodeActivatedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeActivatedEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

[Obsolete($"Incorrect naming: Use {nameof(NodeRemovingEventExtensions)}")]
public static class NodeActivatedEventExtensions
{
	[Obsolete($"Incorrect naming: Use {nameof(NodeRemovingEventExtensions)}.{nameof(PublishNodeRemoved)}")]
	public static void PublishNodeRemoved(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeActivatedEvent>()
			.Publish(new NodeActivatedEventArgs(nodeId));
	}

	[Obsolete($"Incorrect naming: Use {nameof(NodeRemovingEventExtensions)}.{nameof(SubscribeNodeRemoved)}")]
	public static SubscriptionToken SubscribeNodeRemoved(
		this IEventAggregator eventAggregator,
		Action<NodeActivatedEventArgs> action,
		Predicate<NodeActivatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeActivatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
