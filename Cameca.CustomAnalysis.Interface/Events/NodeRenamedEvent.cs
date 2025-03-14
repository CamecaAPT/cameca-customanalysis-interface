﻿using Prism.Events;
using System;

namespace Cameca.CustomAnalysis.Interface;

public class NodeRenamedEvent : PubSubEvent<NodeRenamedEventArgs> { }

public class NodeRenamedEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public NodeRenamedEventArgs(Guid nodeId)
	{
		NodeId = nodeId;
	}
}

public static class NodeRenamedEventExtensions
{
	public static void PublishNodeRenamed(
		this IEventAggregator eventAggregator,
		Guid nodeId)
	{
		eventAggregator
			.GetEvent<NodeRenamedEvent>()
			.Publish(new NodeRenamedEventArgs(nodeId));
	}

	public static SubscriptionToken SubscribeNodeRenamed(
		this IEventAggregator eventAggregator,
		Action<NodeRenamedEventArgs> action,
		Predicate<NodeRenamedEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<NodeRenamedEvent>()
			.Subscribe(action, filter: filter);
	}
}