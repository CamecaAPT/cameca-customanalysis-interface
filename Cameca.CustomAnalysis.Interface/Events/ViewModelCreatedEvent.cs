using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelCreatedEvent : PubSubEvent<ViewModelCreatedEventArgs> { }

public class ViewModelCreatedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public Guid OwnerNodeId { get; }

	public ViewModelMode Mode { get; }

	public ViewModelCreatedEventArgs(Guid viewModelId, Guid ownerNodeId, ViewModelMode mode)
	{
		ViewModelId = viewModelId;
		OwnerNodeId = ownerNodeId;
		Mode = mode;
	}
}

public static class ViewModelCreatedEventExtensions
{
	public static void PublishViewModelCreated(
		this IEventAggregator eventAggregator,
		Guid viewModelId,
		Guid ownerNodeId,
		ViewModelMode mode)
	{
		eventAggregator
			.GetEvent<ViewModelCreatedEvent>()
			.Publish(new ViewModelCreatedEventArgs(viewModelId, ownerNodeId, mode));
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