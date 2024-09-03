using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NetFundamentos.Common.Models
{
    public class PessoaSeg
    {   
        public PessoaSeg()   //Construtor
        {

        }
        
        public PessoaSeg(String nome, string sobrenome)  //   CONSTRUTOR
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome 
        {   
            get => _nome.ToUpper(); //OUTRA MANEIRA DE 
                                    // FAZER O COMANDO ABAIXO

          //  get
              // {
              //     return _nome.ToUpper();
              // } 
                
            set
            {
                if (value =="")
                {
                    throw new ArgumentException ("O nome não pode ser vazio");
                }

                _nome = value;
            } 
        
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int idade 
        { 
            get => _idade;
            
            set
            {
              if (value < 0)
                {
                    throw new ArgumentException ("idade não pode ser menor que zero");
                }  

                _idade = value;
            } 
            
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade:{idade}");

        }
    }
}