using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeDeletedEvent : PubSubEvent<AnalysisTreeDeletedEventArgs> { }

public class AnalysisTreeDeletedEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public AnalysisTreeDeletedEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class AnalysisTreeDeletedEventExtensions
{
	public static void PublishAnalysisTreeDeleted(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<AnalysisTreeDeletedEvent>()
			.Publish(new AnalysisTreeDeletedEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisTreeDeleted(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeDeletedEventArgs> action,
		Predicate<AnalysisTreeDeletedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeDeletedEvent>()
			.Subscribe(action, filter: filter);
	}
}
