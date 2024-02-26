using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeCreatedEvent : PubSubEvent<AnalysisTreeCreatedEventArgs> { }

public class AnalysisTreeCreatedEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public EventTrigger Trigger { get; }

	public AnalysisTreeCreatedEventArgs(Guid analysisTreeId, EventTrigger eventTrigger)
	{
		AnalysisTreeId = analysisTreeId;
		Trigger = eventTrigger;
	}
}

public static class AnalysisTreeCreatedEventExtensions
{
	public static void PublishAnalysisTreeCreated(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId,
		EventTrigger eventTrigger)
	{
		eventAggregator
			.GetEvent<AnalysisTreeCreatedEvent>()
			.Publish(new AnalysisTreeCreatedEventArgs(analysisTreeId, eventTrigger));
	}

	public static SubscriptionToken SubscribeAnalysisTreeCreated(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeCreatedEventArgs> action,
		Predicate<AnalysisTreeCreatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeCreatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
