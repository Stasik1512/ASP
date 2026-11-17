using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;


namespace Academy.Models
{
    [PrimaryKey(nameof(discipline), nameof(dependent_discipline))]
    public class DependentDisciplines
    {
        [Column("discipline", TypeName = "SMALLINT")]
        [ForeignKey(nameof(this.Discipline))]
        public int discipline { get; set; }

        [Column("dependent_discipline", TypeName = "SMALLINT")]
        [ForeignKey(nameof(this.DependentDispline))]
        public int dependent_discipline { get; set; }

        //NAVIGATION

        public Discipline  Discipline { get; set; }
        public Discipline DependentDispline { get; set; }
    }
}
