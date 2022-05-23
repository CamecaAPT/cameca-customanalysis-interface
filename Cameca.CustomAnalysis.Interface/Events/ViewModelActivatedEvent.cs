using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelActivatedEvent : PubSubEvent<ViewModelActivatedEventArgs> { }

public class ViewModelActivatedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ViewModelActivatedEventArgs(Guid analysisViewModelId)
	{
		ViewModelId = analysisViewModelId;
	}
}

public static class ViewModelActivatedEventExtensions
{
	public static void PublishViewModelActivated(
		this IEventAggregator eventAggregator,
		Guid analysisViewModelId)
	{
		eventAggregator
			.GetEvent<ViewModelActivatedEvent>()
			.Publish(new ViewModelActivatedEventArgs(analysisViewModelId));
	}

	public static SubscriptionToken SubscribeViewModelActivated(
		this IEventAggregator eventAggregator,
		Action<ViewModelActivatedEventArgs> action,
		Predicate<ViewModelActivatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelActivatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
