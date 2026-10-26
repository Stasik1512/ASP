using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
	//Movie это модель
	//Модель это класс описываеющий данные  хранящиеся в базе данных
	//Точнее, модель описывает структуру записи определенной таблицы в базе данных 
	//а именно, каждое поле модели соответствует определенному полю таблицы в базе данных
	public class Movie
	{
		public int Id { get; set; }

		//[DataAnnotation]
		//DataAnnotation пишутся в кв скобках перед моделью И  перед ее полями
		// и предназначена для уточнения свойств модели, либо ее полей
		[Required] 
		// -> ОБЯЗАТЕЛЬНЫЙ
		[StringLength(50, MinimumLength = (2))]
		public string Title { get; set; }
		public DateOnly ReleaseDate { get; set; }
		public string URL { get; set; }
		public string Poster { get; set; }
	}
}
