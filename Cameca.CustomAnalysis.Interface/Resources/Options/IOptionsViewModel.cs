using System;
using System.ComponentModel;

namespace Cameca.CustomAnalysis.Interface;

public interface IOptionsViewModel<TOptionsModel> : INotifyPropertyChanged
	where TOptionsModel : class, IEquatable<TOptionsModel>, INotifyPropertyChanged, ICloneable, new()
{
	TOptionsModel? Options { get; set; }
}
