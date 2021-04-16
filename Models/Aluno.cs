using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExAluno.Models
{
    public class Aluno
    {
        [Key]
        public long? AlunoID { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]

        public int Idade { get; set; }
        [Required]
        public string Sala { get; set; }
        
        [Required]
        public string Sexo { get; set; }
        [Required]
        public float Media { get; set; }
    }
}
