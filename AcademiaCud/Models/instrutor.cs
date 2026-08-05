using System.ComponentModel.DataAnnotations;

namespace AcademiaCud.Models
{
    public class instrutor
    {
        [Key]
        public int idInstrutor { get; set; }
        [MaxLength(150)]
        public string nome { get; set;}
        public string email { get; set;}
        public string telefone { get; set;}
        public string sexo { get; set; }
        public int idade { get; set; }

    }
}
