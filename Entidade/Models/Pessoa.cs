using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade.Models
{
    [Table("PESSOA")]
    public class Pessoa
    {
        [Column("ID_PESSOA")]

        public int Id { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("IDADE")]
        public int Idade { get; set; }
    }
}
