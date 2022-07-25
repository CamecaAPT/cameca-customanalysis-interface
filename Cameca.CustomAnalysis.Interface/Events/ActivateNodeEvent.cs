using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ActivateNodeEvent : PubSubEvent<ActivateNodeEventArgs> { }

public class ActivateNodeEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public ActivateNodeEventArgs(Guid nodeId)
	{
		NodeId = nodeId;
	}
}

public static class ActivateNodeEventExtensions
{
	public static void PublishActivateNode(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<ActivateNodeEvent>()
			.Publish(new ActivateNodeEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeActivateNode(
		this IEventAggregator eventAggregator,
		Action<ActivateNodeEventArgs> action,
		Predicate<ActivateNodeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ActivateNodeEvent>()
			.Subscribe(action, filter: filter);
	}
}
