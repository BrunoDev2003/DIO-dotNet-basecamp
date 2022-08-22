using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploFundamentos_dotnet.com.Models
{
    public class Calculadora
    {   
        /// <summary>
        /// Realiza uma soma de 2 numeros.
        /// </summary>
        /// <param name="x" > o primeiro numero inteiro para subtrair</param>
        /// <param name="y" > o segundo numero inteiro para subtrair</param>
        public void Somar(int x, int y) { 
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtracao(int x, int y) { 
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicacao(int x, int y) { 
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Divisao(int x, int y) { 
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencial(int x, int y) {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo) {
            double radiano = angulo + Math.PI / 180;
            double seno = Math.Sin(radiano);
            Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
        }

        public void Coseno(double angulo) {
            double radiano = angulo + Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(coseno,4)}");
        }

        public void Tangente(double angulo) {
            double radiano = angulo + Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Math.Tan(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(tangente,4)}");
        }
    }
}