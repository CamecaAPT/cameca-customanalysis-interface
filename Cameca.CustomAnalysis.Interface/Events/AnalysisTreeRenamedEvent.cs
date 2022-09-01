using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeRenamedEvent : PubSubEvent<AnalysisTreeRenamedEventArgs> { }

public class AnalysisTreeRenamedEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public AnalysisTreeRenamedEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class AnalysisTreeRenamedEventExtensions
{
	public static void PublishAnalysisTreeRenamed(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<AnalysisTreeRenamedEvent>()
			.Publish(new AnalysisTreeRenamedEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisTreeRenamed(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeRenamedEventArgs> action,
		Predicate<AnalysisTreeRenamedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeRenamedEvent>()
			.Subscribe(action, filter: filter);
	}
}
