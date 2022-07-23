using System;
using Prism.Events;

namespace Cameca.CustomAnalysis.Interface;

public class DeleteNodeEvent : PubSubEvent<DeleteNodeEventArgs> { }

public class DeleteNodeEventArgs : INodeTargetEvent
{
	public Guid NodeId { get; }

	public bool ConfirmationPrompt { get; }
	
	public DeleteNodeEventArgs(Guid nodeId, bool confirmationPrompt = true)
	{
		NodeId = nodeId;
		ConfirmationPrompt = confirmationPrompt;
	}
}

public static class DeleteNodeEventExtensions
{
	public static void PublishDeleteNode(
		this IEventAggregator eventAggregator,
		Guid nodeId,
		bool confirmationPrompt = true)
	{
		eventAggregator
			.GetEvent<DeleteNodeEvent>()
			.Publish(new DeleteNodeEventArgs(nodeId, confirmationPrompt));
	}

	public static SubscriptionToken SubscribeDeleteNode(
		this IEventAggregator eventAggregator,
		Action<DeleteNodeEventArgs> action,
		Predicate<DeleteNodeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<DeleteNodeEvent>()
			.Subscribe(action, filter: filter);
	}
}

