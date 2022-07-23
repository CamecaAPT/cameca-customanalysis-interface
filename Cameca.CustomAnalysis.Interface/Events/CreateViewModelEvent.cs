using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class CreateViewModelEvent : PubSubEvent<CreateViewModelEventArgs> { }

public class CreateViewModelEventArgs : INodeTargetEvent
{
	public string ViewModelName { get; }

	public Guid NodeId { get; }

	public ViewModelMode Mode { get; }

	public byte[]? Data { get; }

	public Predicate<object>? MatchExisting { get; }

	public CreateViewModelEventArgs(string viewModelName, Guid nodeId, ViewModelMode mode, byte[]? data = null, Predicate<object>? matchExisting = null)
	{
		ViewModelName = viewModelName;
		NodeId = nodeId;
		Mode = mode;
		Data = data;
		MatchExisting = matchExisting;
	}
}

public static class CreateViewModelEventExtensions
{
	public static void PublishDisplayView(
		this IEventAggregator eventAggregator,
		string viewModelName,
		Guid ownerNodeId,
		ViewModelMode mode,
		byte[]? data = null,
		Predicate<object>? matchExisting = null)
	{
		eventAggregator
			.GetEvent<CreateViewModelEvent>()
			.Publish(new CreateViewModelEventArgs(viewModelName, ownerNodeId, mode, data, matchExisting));
	}

	public static SubscriptionToken SubscribeDisplayView(
		this IEventAggregator eventAggregator,
		Action<CreateViewModelEventArgs> action,
		Predicate<CreateViewModelEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<CreateViewModelEvent>()
			.Subscribe(action, filter: filter);
	}
}
