using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelAddedEvent : PubSubEvent<ViewModelAddedEventArgs> { }

public class ViewModelAddedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public Guid OwnerNodeId { get; }

	public ViewModelAddedEventArgs(Guid viewModelId, Guid ownerNodeId)
	{
		ViewModelId = viewModelId;
		OwnerNodeId = ownerNodeId;
	}
}

public static class ViewModelAddedEventExtensions
{
	public static void PublishViewModelAdded(
		this IEventAggregator eventAggregator,
		Guid viewModelId,
		Guid ownerNodeId)
	{
		eventAggregator
			.GetEvent<ViewModelAddedEvent>()
			.Publish(new ViewModelAddedEventArgs(viewModelId, ownerNodeId));
	}

	public static SubscriptionToken SubscribeViewModelAdded(
		this IEventAggregator eventAggregator,
		Action<ViewModelAddedEventArgs> action,
		Predicate<ViewModelAddedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelAddedEvent>()
			.Subscribe(action, filter: filter);
	}
}