using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelAddedEvent : PubSubEvent<ViewModelAddedEventArgs> { }

public class ViewModelAddedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ViewModelAddedEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class ViewModelAddedEventExtensions
{
	public static void PublishViewModelCreated(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<ViewModelAddedEvent>()
			.Publish(new ViewModelAddedEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeViewModelCreated(
		this IEventAggregator eventAggregator,
		Action<ViewModelAddedEventArgs> action,
		Predicate<ViewModelAddedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelAddedEvent>()
			.Subscribe(action, filter: filter);
	}
}