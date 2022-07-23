using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class RenameViewModelEvent : PubSubEvent<RenameViewModelEventArgs> { }

public class RenameViewModelEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public string Name { get; }

	public RenameViewModelEventArgs(Guid viewModelId, string name)
	{
		ViewModelId = viewModelId;
		Name = name;
	}
}

public static class RenameViewModelEventExtensions
{
	public static void PublishViewModelRename(
		this IEventAggregator eventAggregator,
		Guid nodeId,
		string name)
	{
		eventAggregator
			.GetEvent<RenameViewModelEvent>()
			.Publish(new RenameViewModelEventArgs(nodeId, name));
	}

	public static SubscriptionToken SubscribeViewModelRename(
		this IEventAggregator eventAggregator,
		Action<RenameViewModelEventArgs> action,
		Predicate<RenameViewModelEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<RenameViewModelEvent>()
			.Subscribe(action, filter: filter);
	}
}
