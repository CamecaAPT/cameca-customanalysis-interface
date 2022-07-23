using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class CloseAnalysisTreeEvent : PubSubEvent<CloseAnalysisTreeEventArgs> { }

public class CloseAnalysisTreeEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public CloseAnalysisTreeEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class CloseAnalysisTreeEventExtensions
{
	public static void PublishNodeClose(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<CloseAnalysisTreeEvent>()
			.Publish(new CloseAnalysisTreeEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeNodeClose(
		this IEventAggregator eventAggregator,
		Action<CloseAnalysisTreeEventArgs> action,
		Predicate<CloseAnalysisTreeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<CloseAnalysisTreeEvent>()
			.Subscribe(action, filter: filter);
	}
}

