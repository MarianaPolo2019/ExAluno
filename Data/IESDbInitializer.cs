using ExAluno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExAluno.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alunos.Any())
            {
                return;
            }

            var alunos = new Aluno[]
            {
                new Aluno{Nome = "Vanessa", Idade=15, Sala="3° A", Sexo="F", Media=10},
                new Aluno{Nome = "Flaviana", Idade=18, Sala="6° F", Sexo="F", Media=7},
                new Aluno{Nome = "Gilberto", Idade=11, Sala="2° B", Sexo="M", Media=4},
                new Aluno{Nome = "Bruno", Idade=13, Sala="3° B", Sexo="M", Media=10},
                new Aluno{Nome = "Fernando", Idade=13, Sala="3° C", Sexo="M", Media=9},
                new Aluno{Nome = "Iara", Idade=14, Sala="4° B", Sexo="F", Media=9},
                new Aluno{Nome = "Yanne", Idade=12, Sala="3° A", Sexo="F", Media=8},
                new Aluno{Nome = "Roberto", Idade=16, Sala="5° D", Sexo="M", Media=6},
                new Aluno{Nome = "Icaro", Idade=14, Sala="4° E", Sexo="F", Media=8},
                new Aluno{Nome = "Célio", Idade=16, Sala="5° A", Sexo="M", Media=9},

            };


            foreach (Aluno a in alunos)
            {
                context.Alunos.Add(a);
            }

            context.SaveChanges();

        }
    }
}
