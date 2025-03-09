using System;

namespace Cameca.CustomAnalysis.Interface;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class FilePathAttribute : Attribute
{
	public bool AllowMultiple { get; set; }
	public string? Filter { get; set; }
}
