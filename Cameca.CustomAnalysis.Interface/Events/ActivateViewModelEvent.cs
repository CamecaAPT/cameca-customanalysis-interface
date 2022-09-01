using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ActivateViewModelEvent : PubSubEvent<ActivateViewModelEventArgs> { }

public class ActivateViewModelEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ActivateViewModelEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class ActivateViewModelEventExtensions
{
	public static void PublishActivateViewModel(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<ActivateViewModelEvent>()
			.Publish(new ActivateViewModelEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeActivateViewModel(
		this IEventAggregator eventAggregator,
		Action<ActivateViewModelEventArgs> action,
		Predicate<ActivateViewModelEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ActivateViewModelEvent>()
			.Subscribe(action, filter: filter);
	}
}
