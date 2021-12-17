using System.ComponentModel.DataAnnotations;

namespace Cameca.CustomAnalysis.Interface.IonData
{
	public enum SectionRelType
	{
		Unknown = 0,
		[Display(Name = "One-to-one", Description = "One-to-one ion to record mapping. No index needed.")]
		OneToOne = 1,
		[Display(Name = "Indexed", Description = "Sparse data. Every record has an 64bit ion index as it's first element.")]
		Indexed = 2,
		[Display(Name = "Unrelated", Description = "Records are not related to ion indicies at all.")]
		Unrelated = 3,
		[Display(Name = "One-to-many", Description = "Each record relates to a number of indicies.  First element is # of indices, then a list, then the record itself.")]
		OneToMany = 4,
	};
}
