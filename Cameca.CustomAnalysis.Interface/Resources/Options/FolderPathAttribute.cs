using System;

namespace Cameca.CustomAnalysis.Interface;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class FolderPathAttribute : Attribute
{
	public bool AllowMultiple { get; set; }
}
