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
	public static void PublishRenameViewModel(
		this IEventAggregator eventAggregator,
		Guid viewModelId,
		string name)
	{
		eventAggregator
			.GetEvent<RenameViewModelEvent>()
			.Publish(new RenameViewModelEventArgs(viewModelId, name));
	}

	public static SubscriptionToken SubscribeRenameViewModel(
		this IEventAggregator eventAggregator,
		Action<RenameViewModelEventArgs> action,
		Predicate<RenameViewModelEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<RenameViewModelEvent>()
			.Subscribe(action, filter: filter);
	}
}
