using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace Movies.Models

{
    public class Model
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public DateOnly RelasseDate { get; set; }
        public string URL { get; set; }
        public string Poster {  get; set; }

    }
}
