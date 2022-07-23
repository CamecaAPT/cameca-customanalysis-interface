using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeClosingEvent : PubSubEvent<AnalysisTreeClosingEventArgs> { }

public class AnalysisTreeClosingEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public AnalysisTreeClosingEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class AnalysisTreeClosingEventExtensions
{
	public static void PublishAnalysisTreeClosing(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<AnalysisTreeClosingEvent>()
			.Publish(new AnalysisTreeClosingEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisTreeClosing(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeClosingEventArgs> action,
		Predicate<AnalysisTreeClosingEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeClosingEvent>()
			.Subscribe(action, filter: filter);
	}
}
