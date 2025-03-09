using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class UpdateViewModelEvent : PubSubEvent<UpdateViewModelEventArgs> { }

public class UpdateViewModelEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public UpdateViewModelEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class UpdateViewModelEventExtensions
{
	public static void PublishUpdateViewModel(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<UpdateViewModelEvent>()
			.Publish(new UpdateViewModelEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeUpdateViewModel(
		this IEventAggregator eventAggregator,
		Action<UpdateViewModelEventArgs> action,
		Predicate<UpdateViewModelEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<UpdateViewModelEvent>()
			.Subscribe(action, filter: filter);
	}
}