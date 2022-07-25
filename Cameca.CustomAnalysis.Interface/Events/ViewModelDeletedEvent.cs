using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelDeletedEvent : PubSubEvent<ViewModelDeletedEventArgs> { }

public class ViewModelDeletedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ViewModelDeletedEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class ViewModelDeletedEventExtensions
{
	public static void PublishViewModelDeleted(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<ViewModelDeletedEvent>()
			.Publish(new ViewModelDeletedEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeViewModelDeleted(
		this IEventAggregator eventAggregator,
		Action<ViewModelDeletedEventArgs> action,
		Predicate<ViewModelDeletedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelDeletedEvent>()
			.Subscribe(action, filter: filter);
	}
}