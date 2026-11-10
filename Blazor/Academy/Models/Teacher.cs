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
		[Column(TypeName = "SMALLINT")]
		public int teacher_id { get; set; }

		public DateOnly work_since { get; set; }

		[Column(TypeName = "SMALLMONEY")]
		public int rate { get; set; }

		//Calculateted properties:
		public int experience
		{
			get => (int)((DateTime.Now.Date - work_since.ToDateTime(new TimeOnly(0)).Date).Days / 365.25);

		}

	}
}
