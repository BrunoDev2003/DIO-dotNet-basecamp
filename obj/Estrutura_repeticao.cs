using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploFundamentos_dotnet.obj
{
    public class Estrutura_repeticao
    {
        int numero = 5;
        int contador = 0;
        while (contador <= 10) {
             Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador++;
        }
        for(int contador = 0; contador <= 10; contador++) {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        }
    }
}