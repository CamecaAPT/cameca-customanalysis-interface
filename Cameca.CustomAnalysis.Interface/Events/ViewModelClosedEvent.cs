using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelClosedEvent : PubSubEvent<ViewModelClosedEventArgs> { }

public class ViewModelClosedEventArgs : INodeTargetEvent, IViewModelTargetEvent
{
	public string ViewModelName { get; }
	public Guid NodeId { get; }
	public Guid ViewModelId { get; }

	public ViewModelClosedEventArgs(string viewModelName, Guid analysisViewModelId, Guid analysisNodeId)
	{
		ViewModelName = viewModelName;
		NodeId = analysisNodeId;
		ViewModelId = analysisViewModelId;
	}
}

public static class ViewModelClosedEventExtensions
{
	public static void PublishViewModelClosed(this IEventAggregator eventAggregator,
		string viewModelName,
		Guid viewModelId,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<ViewModelClosedEvent>()
			.Publish(new ViewModelClosedEventArgs(viewModelName, viewModelId, nodeId));
	}

	public static SubscriptionToken SubscribeViewModelClosed(
		this IEventAggregator eventAggregator,
		Action<ViewModelClosedEventArgs> action,
		Predicate<ViewModelClosedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelClosedEvent>()
			.Subscribe(action, filter: filter);
	}
}
