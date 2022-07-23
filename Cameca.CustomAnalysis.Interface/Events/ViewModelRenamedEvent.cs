using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelRenamedEvent : PubSubEvent<ViewModelRenamedEventArgs> { }

public class ViewModelRenamedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ViewModelRenamedEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class ViewModelRenamedEventExtensions
{
	public static void PublishViewModelCreated(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<ViewModelRenamedEvent>()
			.Publish(new ViewModelRenamedEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeViewModelCreated(
		this IEventAggregator eventAggregator,
		Action<ViewModelRenamedEventArgs> action,
		Predicate<ViewModelRenamedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelRenamedEvent>()
			.Subscribe(action, filter: filter);
	}
}