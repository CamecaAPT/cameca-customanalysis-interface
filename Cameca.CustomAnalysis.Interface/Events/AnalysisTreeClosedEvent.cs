using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeClosedEvent : PubSubEvent<AnalysisTreeClosedEventArgs> { }

public class AnalysisTreeClosedEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public AnalysisTreeClosedEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class AnalysisTreeClosedEventExtensions
{
	public static void PublishAnalysisTreeClosed(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<AnalysisTreeClosedEvent>()
			.Publish(new AnalysisTreeClosedEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisTreeClosed(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeClosedEventArgs> action,
		Predicate<AnalysisTreeClosedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeClosedEvent>()
			.Subscribe(action, filter: filter);
	}
}
