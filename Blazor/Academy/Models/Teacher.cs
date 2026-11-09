using Academy.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Academy.Models
{
	public class Teacher : Human
	{
		[Key]
		public short teacher_id { get; set; }

		public DateOnly work_since { get; set; }
		
		public SqlMoney rate { get; set; }
	}
}
