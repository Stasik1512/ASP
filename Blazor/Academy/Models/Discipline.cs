using Academy.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Academy.Models
{
    public class Discipline
    {
        [Key]
        public int      discipline_id { get; set; }
        [Required]
        public string   discipline_name { get; set; }
        [Required]
        [Column("number_of_lessons", TypeName ="TINYINT")]
        public int number_of_lessons { get; set; }
    }
}
