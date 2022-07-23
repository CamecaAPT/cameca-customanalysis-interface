using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelCreatedEvent : PubSubEvent<ViewModelCreatedEventArgs> { }

public class ViewModelCreatedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ViewModelMode Mode { get; }

	public ViewModelCreatedEventArgs(Guid viewModelId, ViewModelMode mode)
	{
		ViewModelId = viewModelId;
		Mode = mode;
	}
}

public static class ViewModelCreatedEventExtensions
{
	public static void PublishViewModelCreated(
		this IEventAggregator eventAggregator,
		Guid viewModelId,
		ViewModelMode mode)
	{
		eventAggregator
			.GetEvent<ViewModelCreatedEvent>()
			.Publish(new ViewModelCreatedEventArgs(viewModelId, mode));
	}

	public static SubscriptionToken SubscribeViewModelCreated(
		this IEventAggregator eventAggregator,
		Action<ViewModelCreatedEventArgs> action,
		Predicate<ViewModelCreatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelCreatedEvent>()
			.Subscribe(action, filter: filter);
	}
}