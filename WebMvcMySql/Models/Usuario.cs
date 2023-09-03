using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvcMySql.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Name")]
        public string Nome { get; set; }

    }
}
