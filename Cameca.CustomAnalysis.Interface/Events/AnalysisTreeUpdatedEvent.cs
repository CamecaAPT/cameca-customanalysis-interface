using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeUpdatedEvent : PubSubEvent<AnalysisTreeUpdatedEventArgs> { }

public class AnalysisTreeUpdatedEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public AnalysisTreeUpdatedEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class AnalysisTreeUpdatedEventExtensions
{
	public static void PublishAnalysisTreeUpdated(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<AnalysisTreeUpdatedEvent>()
			.Publish(new AnalysisTreeUpdatedEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisTreeUpdated(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeUpdatedEventArgs> action,
		Predicate<AnalysisTreeUpdatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeUpdatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
