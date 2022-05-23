using System;

namespace Cameca.CustomAnalysis.Interface;

public class CustomAnalysisException : Exception
{
    public CustomAnalysisException()
        : base()
    {
    }

    public CustomAnalysisException(string message)
        : base(message)
    {
    }


    public CustomAnalysisException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}