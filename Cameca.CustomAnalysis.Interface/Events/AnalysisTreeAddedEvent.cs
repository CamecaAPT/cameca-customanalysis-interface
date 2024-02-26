using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeAddedEvent : PubSubEvent<AnalysisTreeAddedEventArgs> { }

public class AnalysisTreeAddedEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public AnalysisTreeAddedEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class AnalysisTreeAddedEventExtensions
{
	public static void PublishAnalysisTreeAdded(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<AnalysisTreeAddedEvent>()
			.Publish(new AnalysisTreeAddedEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisTreeAdded(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeAddedEventArgs> action,
		Predicate<AnalysisTreeAddedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeAddedEvent>()
			.Subscribe(action, filter: filter);
	}
}
