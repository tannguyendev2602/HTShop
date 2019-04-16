using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Models
{
	[Table("TanTests")]
	public class TanTests
	{
		[Required]
		public string ID { get; set; }

		public string Name { get; set; }
	}
}
