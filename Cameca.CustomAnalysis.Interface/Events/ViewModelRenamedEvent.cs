﻿using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class ViewModelRenamedEvent : PubSubEvent<ViewModelRenamedEventArgs> { }

public class ViewModelRenamedEventArgs : IViewModelTargetEvent
{
	public Guid ViewModelId { get; }

	public ViewModelRenamedEventArgs(Guid viewModelId)
	{
		ViewModelId = viewModelId;
	}
}

public static class ViewModelRenamedEventExtensions
{
	public static void PublishViewModelRenamed(
		this IEventAggregator eventAggregator,
		Guid viewModelId)
	{
		eventAggregator
			.GetEvent<ViewModelRenamedEvent>()
			.Publish(new ViewModelRenamedEventArgs(viewModelId));
	}

	public static SubscriptionToken SubscribeViewModelRenamed(
		this IEventAggregator eventAggregator,
		Action<ViewModelRenamedEventArgs> action,
		Predicate<ViewModelRenamedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<ViewModelRenamedEvent>()
			.Subscribe(action, filter: filter);
	}
}