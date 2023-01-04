using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelDeletingEvent : PubSubEvent<ViewModelDeletingEventArgs> { }

public class ViewModelDeletingEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ViewModelDeletingEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class ViewModelDeletingEventExtensions
{
	public static void PublishViewModelDeleting(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<ViewModelDeletingEvent>()
			.Publish(new ViewModelDeletingEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeViewModelDeleting(
		this IEventAggregator eventAggregator,
		Action<ViewModelDeletingEventArgs> action,
		Predicate<ViewModelDeletingEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelDeletingEvent>()
			.Subscribe(action, filter: filter);
	}
}