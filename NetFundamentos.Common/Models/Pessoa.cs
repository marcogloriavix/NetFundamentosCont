using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace NetFundamentos.Common.Models
{
    public class Pessoa
    {
        public string? Name { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Name}, e tenho {Idade} anos");
        }
    }
}