using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class DeleteViewModelEvent : PubSubEvent<DeleteViewModelEventArgs> { }

public class DeleteViewModelEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public DeleteViewModelEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class DeleteViewModelEventExtensions
{
	public static void PublishDeleteViewModel(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<DeleteViewModelEvent>()
			.Publish(new DeleteViewModelEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeDeleteViewModel(
		this IEventAggregator eventAggregator,
		Action<DeleteViewModelEventArgs> action,
		Predicate<DeleteViewModelEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<DeleteViewModelEvent>()
			.Subscribe(action, filter: filter);
	}
}

