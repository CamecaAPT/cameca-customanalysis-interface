using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class NodeLoadedEvent : PubSubEvent<NodeLoadedEventArgs> { }

public class NodeLoadedEventArgs : INodeTargetEvent, INodeInstantiatedEventArgs
{
	public Guid NodeId { get; }

	public byte[]? Data { get; }

public NodeLoadedEventArgs(Guid analysisNodeId, byte[]? data = null)
	{
		NodeId = analysisNodeId;
		Data = data;
	}
}

public static class NodeLoadedEventExtensions
{
	public static void PublishNodeLoaded(this IEventAggregator eventAggregator,
		Guid analysisNodeId,
		byte[]? data = null)
	{
		eventAggregator
			.GetEvent<NodeLoadedEvent>()
			.Publish(new NodeLoadedEventArgs(analysisNodeId, data));
	}

	public static SubscriptionToken SubscribeNodeLoaded(
		this IEventAggregator eventAggregator,
		Action<NodeLoadedEventArgs> action,
		Predicate<NodeLoadedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeLoadedEvent>()
			.Subscribe(action, filter: filter);
	}
}

