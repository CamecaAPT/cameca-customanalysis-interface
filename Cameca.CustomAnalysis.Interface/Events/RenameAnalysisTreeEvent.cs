using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class RenameAnalysisTreeEvent : PubSubEvent<RenameAnalysisTreeEventArgs> { }

public class RenameAnalysisTreeEventArgs : IAnalysisTreeTargetEvent
{
	public Guid AnalysisTreeId { get; }

	public string Name { get; }

	public RenameAnalysisTreeEventArgs(Guid analysisTreeId, string name)
	{
		AnalysisTreeId = analysisTreeId;
		Name = name;
	}
}

public static class RenameAnalysisTreeEventExtensions
{
	public static void PublishRenameAnalysisTree(
		this IEventAggregator eventAggregator,
		Guid analysisTreeId,
		string name)
	{
		eventAggregator
			.GetEvent<RenameAnalysisTreeEvent>()
			.Publish(new RenameAnalysisTreeEventArgs(analysisTreeId, name));
	}

	public static SubscriptionToken SubscribeRenameAnalysisTree(
		this IEventAggregator eventAggregator,
		Action<RenameAnalysisTreeEventArgs> action,
		Predicate<RenameAnalysisTreeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<RenameAnalysisTreeEvent>()
			.Subscribe(action, filter: filter);
	}
}
