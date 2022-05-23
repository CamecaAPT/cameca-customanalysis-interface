using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelCreatedEvent : PubSubEvent<ViewModelCreatedEventArgs> { }

public class ViewModelCreatedEventArgs : INodeTargetEvent, IViewModelTargetEvent
{
	public string ViewModelName { get; }

	public Guid NodeId { get; }

	public Guid ViewModelId { get; }

	public ViewModelMode Mode { get; }

	public ViewModelCreatedEventArgs(string viewModelName, Guid analysisViewModelId, Guid analysisNodeId, ViewModelMode mode)
	{
		ViewModelName = viewModelName;
		NodeId = analysisNodeId;
		ViewModelId = analysisViewModelId;
		Mode = mode;
	}
}

public static class ViewModelCreatedEventExtensions
{
	public static void PublishViewModelCreated(this IEventAggregator eventAggregator,
		string viewModelName,
		Guid viewModelId,
		Guid nodeId,
		ViewModelMode mode)
	{
		eventAggregator
			.GetEvent<ViewModelCreatedEvent>()
			.Publish(new ViewModelCreatedEventArgs(viewModelName, viewModelId, nodeId, mode));
	}

	public static SubscriptionToken SubscribeViewModelCreated(
		this IEventAggregator eventAggregator,
		Action<ViewModelCreatedEventArgs> action,
		Predicate<ViewModelCreatedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelCreatedEvent>()
			.Subscribe(action, filter: filter);
	}
}
