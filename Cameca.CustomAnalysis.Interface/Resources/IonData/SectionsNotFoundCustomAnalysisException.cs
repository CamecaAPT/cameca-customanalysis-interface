using System;

namespace Cameca.CustomAnalysis.Interface;

public class SectionsNotFoundCustomAnalysisException : CustomAnalysisException
{
    public SectionsNotFoundCustomAnalysisException()
        : base()
    {
    }

    public SectionsNotFoundCustomAnalysisException(string message)
        : base(message)
    {
    }


    public SectionsNotFoundCustomAnalysisException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
