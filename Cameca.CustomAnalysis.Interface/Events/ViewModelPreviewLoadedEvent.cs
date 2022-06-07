using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelPreviewLoadedEvent : PubSubEvent<ViewModelPreviewLoadedEventArgs> { }

public class ViewModelPreviewLoadedEventArgs : IViewModelTargetEvent
{
	public string ViewModelName { get; }

	public Guid ViewModelId { get; }

	public byte[]? Data { get; }

	public ViewModelPreviewLoadedEventArgs(string viewModelName, Guid analysisViewModelId, byte[]? data = null)
	{
		ViewModelName = viewModelName;
		ViewModelId = analysisViewModelId;
		Data = data;
	}
}

public static class ViewModelPreviewLoadedEventExtensions
{
	public static void PublishViewModelPreviewLoaded(this IEventAggregator eventAggregator,
		string viewModelName,
		Guid viewModelId,
		byte[]? data = null)
	{
		eventAggregator
			.GetEvent<ViewModelPreviewLoadedEvent>()
			.Publish(new ViewModelPreviewLoadedEventArgs(viewModelName, viewModelId, data));
	}

	public static SubscriptionToken SubscribeViewModelPreviewLoaded(
		this IEventAggregator eventAggregator,
		Action<ViewModelPreviewLoadedEventArgs> action,
		Predicate<ViewModelPreviewLoadedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelPreviewLoadedEvent>()
			.Subscribe(action, filter: filter);
	}
}
