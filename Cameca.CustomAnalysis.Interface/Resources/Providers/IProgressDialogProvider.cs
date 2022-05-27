using System;

namespace Cameca.CustomAnalysis.Interface;

public interface IProgressDialogProvider
{
	IProgressDialog? Resolve(Guid instanceId);
}
