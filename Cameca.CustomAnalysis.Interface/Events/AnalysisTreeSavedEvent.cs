using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class AnalysisTreeSavedEvent : PubSubEvent<AnalysisTreeSavedEventArgs> { }

public class AnalysisTreeSavedEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public AnalysisTreeSavedEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class AnalysisTreeSavedEventExtensions
{
	public static void PublishAnalysisTreeSaved(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<AnalysisTreeSavedEvent>()
			.Publish(new AnalysisTreeSavedEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisTreeSaved(
		this IEventAggregator eventAggregator,
		Action<AnalysisTreeSavedEventArgs> action,
		Predicate<AnalysisTreeSavedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<AnalysisTreeSavedEvent>()
			.Subscribe(action, filter: filter);
	}
}
