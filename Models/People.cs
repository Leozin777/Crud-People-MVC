using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvc.Models
{
    [Table("People")]
    public class People
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Column("Name")]
        public string Name { get; set; }

        [Display(Name = "Idade")]
        [Column("Age")]
        public int Age { get; set; }

        [Display(Name = "Telefone")]
        [Column("Phone")]
        public string Phone { get; set; }
    }
}
