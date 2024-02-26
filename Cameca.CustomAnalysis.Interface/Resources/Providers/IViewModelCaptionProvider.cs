using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IViewModelCaptionProvider
{
	IViewModelCaption? Resolve(Guid viewModelId);
}