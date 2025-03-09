using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeActivatedEvent : PubSubEvent<AnalysisTreeActivatedEventArgs> { }

public class AnalysisTreeActivatedEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public AnalysisTreeActivatedEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class AnalysisTreeActivatedEventExtensions
{
	public static void PublishAnalysisTreeActivated(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<AnalysisTreeActivatedEvent>()
			.Publish(new AnalysisTreeActivatedEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisTreeActivated(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeActivatedEventArgs> action,
		Predicate<AnalysisTreeActivatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeActivatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
