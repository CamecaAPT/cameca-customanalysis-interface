using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class DisplayViewEvent : PubSubEvent<DisplayViewEventArgs> { }

public class DisplayViewEventArgs : INodeTargetEvent
{
	public string ViewModelName { get; }

	public Guid NodeId { get; }

	public Predicate<object>? MatchExisting { get; }

	public DisplayViewEventArgs(string viewModelName, Guid nodeId, Predicate<object>? matchExisting = null)
	{
		ViewModelName = viewModelName;
		NodeId = nodeId;
		MatchExisting = matchExisting;
	}
}

public static class DisplayViewEventExtensions
{
	public static void PublishDisplayView(
		this IEventAggregator eventAggregator,
		string viewModelName,
		Guid ownerNodeId,
		Predicate<object>? matchExisting = null)
	{
		eventAggregator
			.GetEvent<DisplayViewEvent>()
			.Publish(new DisplayViewEventArgs(viewModelName, ownerNodeId, matchExisting));
	}

	public static SubscriptionToken SubscribeDisplayView(
		this IEventAggregator eventAggregator,
		Action<DisplayViewEventArgs> action,
		Predicate<DisplayViewEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<DisplayViewEvent>()
			.Subscribe(action, filter: filter);
	}
}
