using System.ComponentModel.DataAnnotations;

namespace Cameca.CustomAnalysis.Interface.IonData;

/// <summary>With the iDataTypeSize field, defines the type of data stored in this section</summary>
public enum SectionRecordDataType
{
    Unknown = 0,
    [Display(Name = "Integer", Description = "Signed integer, typical iDataTypeSize = { 8, 16, 32, 64 }")]
    Int = 1,
    [Display(Name = "Unsigned Int", Description = "Unsigned integer, typical iDataTypeSize = { 8, 16, 32, 64 }")]
    UInt = 2,
    [Display(Name = "Floating Point", Description = "Floating point, typical iDataTypeSize = { 32, 64 }")]
    Float = 3,
    [Display(Name = "Char String", Description = "Character string.  iDataTypeSize = { 8, 16 }. iRecordSize of 0 is null terminated; iRecordSize > 0 is fixed length.")]
    CharString = 4,
    Other = 5,
};