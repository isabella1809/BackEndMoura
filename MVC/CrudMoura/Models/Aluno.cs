using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMoura.Models
{
    public class Aluno
    {
           public int Id {get; set;}
        public string Nome{get; set;}
        public int Sala{get; set;}
        public float nota{get; set;}
        public float CPF{get; set;}
        public float RA{get; set;}
    }
}