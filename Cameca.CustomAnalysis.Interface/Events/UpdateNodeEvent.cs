using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class UpdateNodeEvent : PubSubEvent<UpdateNodeEventArgs> { }

public class UpdateNodeEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public UpdateNodeEventArgs(Guid analysisNodeId)
	{
		NodeId = analysisNodeId;
	}
}

public static class UpdateNodeEventExtensions
{
	public static void PublishUpdateNode(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<UpdateNodeEvent>()
			.Publish(new UpdateNodeEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeUpdateNode(
		this IEventAggregator eventAggregator,
		Action<UpdateNodeEventArgs> action,
		Predicate<UpdateNodeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<UpdateNodeEvent>()
			.Subscribe(action, filter: filter);
	}
}
