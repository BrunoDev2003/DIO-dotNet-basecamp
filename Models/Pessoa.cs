using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplosMetodosConstrutoresDotNet.Models
{
    public class Pessoa
    {
        public Pessoa() { 

        }
        public Pessoa(string nome, string sobrenome) { 
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            }
            
            set
            {
                if (value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        {   get => _idade;

            set
            {
                if (value < 0 ){
                    throw new ArgumentOutOfRangeException("A idade não pode ser menor que zero");
                }
            }
        }

        public void Apresentar() {
            Console.WriteLine($"Nome: {Nome} {Sobrenome}, Idade: {Idade}");
        }
    }
}