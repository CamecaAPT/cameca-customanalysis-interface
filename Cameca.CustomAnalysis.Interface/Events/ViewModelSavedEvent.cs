using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelSavedEvent : PubSubEvent<ViewModelSavedEventArgs> { }

public class ViewModelSavedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ViewModelSavedEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class ViewModelSavedEventExtensions
{
	public static void PublishViewModelCreated(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<ViewModelSavedEvent>()
			.Publish(new ViewModelSavedEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeViewModelCreated(
		this IEventAggregator eventAggregator,
		Action<ViewModelSavedEventArgs> action,
		Predicate<ViewModelSavedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelSavedEvent>()
			.Subscribe(action, filter: filter);
	}
}