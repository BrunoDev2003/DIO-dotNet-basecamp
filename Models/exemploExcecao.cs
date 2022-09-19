using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplosMetodosConstrutoresDotNet.Models
{
    public class exemploExcecao
    {
        public void Metodo1() {
            Metodo2();
        }
        public void Metodo2() {
            Metodo3();
        }
        public void Metodo3() {
            try {
                Metodo4();
            } catch(Exception e) {
                Console.WriteLine("Exceção tratada");
            }
            
        }
        public void Metodo4() {
            throw new Exception("Ocorreu uma exceção");
        }
    }
}