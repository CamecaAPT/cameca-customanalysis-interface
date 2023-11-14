namespace Cameca.CustomAnalysis.Interface;

/// <summary>
/// Factory for creating instances of the IAptFileBuilder used to create new APT files
/// </summary>
public interface IAptFileBuilderFactory
{
	/// <summary>
	/// Create a new instance implementing <see cref="IAptFileBuilder"/>
	/// </summary>
	IAptFileBuilder CreateAptFileBuilder();
}
