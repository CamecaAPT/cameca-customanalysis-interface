using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeInteractedEvent : PubSubEvent<AnalysisTreeInteractedEventArgs> { }

public class AnalysisTreeInteractedEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public InteractionType Interaction { get; }

	public AnalysisTreeInteractedEventArgs(Guid analysisTreeId, InteractionType interaction)
	{
		AnalysisTreeId = analysisTreeId;
		Interaction = interaction;
	}
}

public static class AnalysisTreeInteractedEventExtensions
{
	public static void PublishAnalysisTreeInteracted(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId,
		InteractionType interaction)
	{
		eventAggregator
			.GetEvent<AnalysisTreeInteractedEvent>()
			.Publish(new AnalysisTreeInteractedEventArgs(analysisTreeId, interaction));
	}

	public static SubscriptionToken SubscribeAnalysisTreeInteracted(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeInteractedEventArgs> action,
		Predicate<AnalysisTreeInteractedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeInteractedEvent>()
			.Subscribe(action, filter: filter);
	}
}
