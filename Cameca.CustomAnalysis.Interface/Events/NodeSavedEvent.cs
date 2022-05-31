using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeSavedEvent : PubSubEvent<NodeSavedEventArgs> { }

public class NodeSavedEventArgs : INodeTargetEvent, INodeInstantiatedEventArgs
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
		Guid analysisNodeId)
	{
		eventAggregator
			.GetEvent<NodeSavedEvent>()
			.Publish(new NodeSavedEventArgs(analysisNodeId));
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

