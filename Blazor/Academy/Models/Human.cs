using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Academy.Models
{
    public class Human
    {
        [Required]
        [StringLength(50)]
        [DisplayName("Фамилия")]
        [RegularExpression(@"^[A-ZА-ЯЁ]+[a-zа-яё]*$")]
        public string last_name {  get; set; }


        [Required]
        [StringLength(50)]
        [DisplayName("Имя")]
        [RegularExpression(@"^[A-ZА-ЯЁ]+[a-zа-яё]*$")]
        public string first_name {  get; set; }
        

        [StringLength(50)]
        [DisplayName("Отчество")]
        [RegularExpression(@"^[A-ZА-Я]+[a-zа-я]*$")]
        public string? middle_name {  get; set; }

        [Required]
        [DisplayName("Дата рождения")]
        [Range(typeof(DateOnly), "1950-01-01", "2023-12-31")]
        public DateOnly birth_date { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public byte[]? photo { get; set; }

        // Calculate properties:

        public string full_name
        {
            get => $"{last_name} {first_name} {middle_name}";
        }
        
        public int age
        {
            get => (int)((DateTime.Now.Date - birth_date.ToDateTime(new TimeOnly(0)).Date).Days / 365.25);
        }


    }
}