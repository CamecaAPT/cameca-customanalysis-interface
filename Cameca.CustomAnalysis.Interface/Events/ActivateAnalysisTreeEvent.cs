using Prism.Events;
using System;

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
	public static void PublishActivateAnalysisTree(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<ActivateAnalysisTreeEvent>()
			.Publish(new ActivateAnalysisTreeEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeActivateAnalysisTree(
		this IEventAggregator eventAggregator,
		Action<ActivateAnalysisTreeEventArgs> action,
		Predicate<ActivateAnalysisTreeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ActivateAnalysisTreeEvent>()
			.Subscribe(action, filter: filter);
	}
}
