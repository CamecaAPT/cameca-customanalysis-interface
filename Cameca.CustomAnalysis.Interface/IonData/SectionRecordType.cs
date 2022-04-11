using System.ComponentModel.DataAnnotations;

namespace Cameca.CustomAnalysis.Interface.IonData;

public enum SectionRecordType
{
    Unknown = 0,
    [Display(Name = "Fixed Size", Description = "Each record has a fixed length. Random access is just record * size + header")]
    FixedSize = 1,
    [Display(Name = "Variable Size", Description = "Variable length records.  Each record starts with the length of that record, no random access.")]
    VariableSize = 2,
    [Display(Name = "Variable Indexed", Description = "Variable length records, but with an index table at the beginning of the file that gives access points. Semi-random access.")]
    VariableIndexed = 3,
};