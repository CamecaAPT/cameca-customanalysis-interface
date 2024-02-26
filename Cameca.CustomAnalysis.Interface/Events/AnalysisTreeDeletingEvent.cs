using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeDeletingEvent : PubSubEvent<AnalysisTreeDeletingEventArgs> { }

public class AnalysisTreeDeletingEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public AnalysisTreeDeletingEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class AnalysisTreeDeletingEventExtensions
{
	public static void PublishAnalysisTreeDeleting(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<AnalysisTreeDeletingEvent>()
			.Publish(new AnalysisTreeDeletingEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisTreeDeleting(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeDeletingEventArgs> action,
		Predicate<AnalysisTreeDeletingEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeDeletingEvent>()
			.Subscribe(action, filter: filter);
	}
}
