using Prism.Events;
using System;
using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface;

public class CreateNodeEvent : PubSubEvent<CreateNodeEventArgs> { }

public class CreateNodeEventArgs : INodeTargetEvent
{
	Guid INodeTargetEvent.NodeId => ParentNodeId;

	public string AnalysisNodeName { get; }

	public Guid ParentNodeId { get; }

	public string? Name { get; }

	public ImageSource? Icon { get; }

	public CreateNodeEventArgs(string analysisNodeName, Guid parentNodeId, string? name = null, ImageSource? icon = null)
	{
		AnalysisNodeName = analysisNodeName;
		ParentNodeId = parentNodeId;
		Name = name;
		Icon = icon;
	}
}

public static class CreateNodeEventExtensions
{
	public static void PublishCreateNode(this IEventAggregator eventAggregator,
		string analysisNodeName,
		Guid parentNodeId,
		string? name = null,
		ImageSource? icon = null)
	{
		eventAggregator
			.GetEvent<CreateNodeEvent>()
			.Publish(new CreateNodeEventArgs(analysisNodeName, parentNodeId, name, icon));
	}

	public static SubscriptionToken SubscribeCreateNode(
		this IEventAggregator eventAggregator,
		Action<CreateNodeEventArgs> action,
		Predicate<CreateNodeEventArgs>? filter = null)
	{
		return eventAggregator
			.GetEvent<CreateNodeEvent>()
			.Subscribe(action, filter: filter);
	}
}

