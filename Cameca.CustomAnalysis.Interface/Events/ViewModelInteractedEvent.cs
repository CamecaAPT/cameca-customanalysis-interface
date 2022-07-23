using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelInteractedEvent : PubSubEvent<ViewModelInteractedEventArgs> { }

public class ViewModelInteractedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; set; }

	public InteractionType Interaction { get; }

	public ViewModelInteractedEventArgs(Guid viewModelId, InteractionType interaction)
	{
		ViewModelId = viewModelId;
		Interaction = interaction;
	}
}

public static class ViewModelInteractedEventArgsExtensions
{
	public static void PublishViewModelInteraction(
		this IEventAggregator eventAggregator,
		Guid instanceId,
		InteractionType interaction)
	{
		eventAggregator
			.GetEvent<ViewModelInteractedEvent>()
			.Publish(new ViewModelInteractedEventArgs(instanceId, interaction));
	}

	public static SubscriptionToken SubscribeViewModelInteraction(
		this IEventAggregator eventAggregator,
		Action<ViewModelInteractedEventArgs> action,
		Predicate<ViewModelInteractedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelInteractedEvent>()
			.Subscribe(action, filter: filter);
	}
}