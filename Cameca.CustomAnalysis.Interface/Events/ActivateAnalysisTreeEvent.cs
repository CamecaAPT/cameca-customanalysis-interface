using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ActivateAnalysisTreeEvent : PubSubEvent<ActivateAnalysisTreeEventArgs> { }

public class ActivateAnalysisTreeEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public ActivateAnalysisTreeEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class ActivateAnalysisTreeEventExtensions
{
	public static void PublishAnalysisSetActivateMainView(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<ActivateAnalysisTreeEvent>()
			.Publish(new ActivateAnalysisTreeEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeAnalysisSetActivateMainView(
		this IEventAggregator eventAggregator,
		Action<ActivateAnalysisTreeEventArgs> action,
		Predicate<ActivateAnalysisTreeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ActivateAnalysisTreeEvent>()
			.Subscribe(action, filter: filter);
	}
}
