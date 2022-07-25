using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelUpdatedEvent : PubSubEvent<ViewModelUpdatedEventArgs> { }

public class ViewModelUpdatedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ViewModelUpdatedEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class ViewModelUpdatedEventExtensions
{
	public static void PublishViewModelUpdated(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<ViewModelUpdatedEvent>()
			.Publish(new ViewModelUpdatedEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeViewModelUpdated(
		this IEventAggregator eventAggregator,
		Action<ViewModelUpdatedEventArgs> action,
		Predicate<ViewModelUpdatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelUpdatedEvent>()
			.Subscribe(action, filter: filter);
	}
}