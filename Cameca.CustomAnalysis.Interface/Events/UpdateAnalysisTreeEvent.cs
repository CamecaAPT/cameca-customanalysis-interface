using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class UpdateAnalysisTreeEvent : PubSubEvent<UpdateAnalysisTreeEventArgs> { }

public class UpdateAnalysisTreeEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public UpdateAnalysisTreeEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class UpdateAnalysisTreeEventExtensions
{
	public static void PublishUpdateAnalysisTree(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<UpdateAnalysisTreeEvent>()
			.Publish(new UpdateAnalysisTreeEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeUpdateAnalysisTree(
		this IEventAggregator eventAggregator,
		Action<UpdateAnalysisTreeEventArgs> action,
		Predicate<UpdateAnalysisTreeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<UpdateAnalysisTreeEvent>()
			.Subscribe(action, filter: filter);
	}
}