using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.Models
{
    public class Livro
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage="Digite o titulo do texto!")]
        [StringLength(100, ErrorMessage="O tamannho maximo de caracteres é {0}")]
        public string Titulo { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public bool Disponibilidade { get; set; }


    }
}
