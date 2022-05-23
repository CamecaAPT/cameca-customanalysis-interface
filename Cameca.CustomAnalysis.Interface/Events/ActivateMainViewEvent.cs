using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ActivateMainViewEvent : PubSubEvent<ActivateMainViewEventArgs> { }

public class ActivateMainViewEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public ActivateMainViewEventArgs(Guid nodeId)
	{
		NodeId = nodeId;
	}
}

public static class ActivateMainViewEventExtensions
{
	public static void PublishActivateMainView(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<ActivateMainViewEvent>()
			.Publish(new ActivateMainViewEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeActivateMainView(
		this IEventAggregator eventAggregator,
		Action<ActivateMainViewEventArgs> action,
		Predicate<ActivateMainViewEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ActivateMainViewEvent>()
			.Subscribe(action, filter: filter);
	}
}
