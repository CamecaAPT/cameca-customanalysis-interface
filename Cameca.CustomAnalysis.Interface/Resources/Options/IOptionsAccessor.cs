namespace Cameca.CustomAnalysis.Interface;

public interface IOptionsAccessor
{
	TOptionsModel GetOptions<TOptionsModel>() where TOptionsModel : class, new();
}
