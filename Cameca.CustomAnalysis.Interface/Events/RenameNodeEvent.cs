using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class RenameNodeEvent : PubSubEvent<RenameNodeEventArgs> { }

public class RenameNodeEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public string Name { get; }

	public RenameNodeEventArgs(Guid analysisNodeId, string name)
	{
		NodeId = analysisNodeId;
		Name = name;
	}
}

public static class RenameNodeEventExtensions
{
	public static void PublishNodeRename(
		this IEventAggregator eventAggregator,
		Guid nodeId,
		string name)
	{
		eventAggregator
			.GetEvent<RenameNodeEvent>()
			.Publish(new RenameNodeEventArgs(nodeId, name));
	}

	public static SubscriptionToken SubscribeNodeRename(
		this IEventAggregator eventAggregator,
		Action<RenameNodeEventArgs> action,
		Predicate<RenameNodeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<RenameNodeEvent>()
			.Subscribe(action, filter: filter);
	}
}
