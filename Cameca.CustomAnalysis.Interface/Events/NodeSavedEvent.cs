using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class NodeSavedEvent : PubSubEvent<NodeSavedEventArgs> { }

public class NodeSavedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeSavedEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class NodeSavedEventExtensions
{
	public static void PublishNodeSaved(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeSavedEvent>()
			.Publish(new NodeSavedEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeSaved(
		this IEventAggregator eventAggregator,
		Action<NodeSavedEventArgs> action,
		Predicate<NodeSavedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeSavedEvent>()
			.Subscribe(action, filter: filter);
	}
}

