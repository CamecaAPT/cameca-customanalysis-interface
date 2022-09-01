using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class SaveAnalysisTreeEvent : PubSubEvent<SaveAnalysisTreeEventArgs> { }

public class SaveAnalysisTreeEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public SaveAnalysisTreeEventArgs(Guid analysisTreeId)
	{
		AnalysisTreeId = analysisTreeId;
	}
}

public static class SaveAnalysisTreeEventExtensions
{
	public static void PublishSaveAnalysisTree(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId)
	{
		eventAggregator
			.GetEvent<SaveAnalysisTreeEvent>()
			.Publish(new SaveAnalysisTreeEventArgs(analysisTreeId));
	}

	public static SubscriptionToken SubscribeSaveAnalysisTree(
		this IEventAggregator eventAggregator,
		Action<SaveAnalysisTreeEventArgs> action,
		Predicate<SaveAnalysisTreeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<SaveAnalysisTreeEvent>()
			.Subscribe(action, filter: filter);
	}
}
