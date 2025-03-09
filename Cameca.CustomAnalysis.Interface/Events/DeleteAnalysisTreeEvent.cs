using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class DeleteAnalysisTreeEvent : PubSubEvent<DeleteAnalysisTreeEventArgs> { }

public class DeleteAnalysisTreeEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public DeleteAnalysisTreeEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class DeleteAnalysisTreeEventExtensions
{
	public static void PublishDeleteAnalysisTree(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<DeleteAnalysisTreeEvent>()
			.Publish(new DeleteAnalysisTreeEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeDeleteAnalysisTree(
		this IEventAggregator eventAggregator,
		Action<DeleteAnalysisTreeEventArgs> action,
		Predicate<DeleteAnalysisTreeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<DeleteAnalysisTreeEvent>()
			.Subscribe(action, filter: filter);
	}
}

