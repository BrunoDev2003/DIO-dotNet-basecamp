using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplosMetodosConstrutoresDotNet.Models
{
    public class leituraArquivo {
        public (bool Sucesso, string[] linhas, int QuantidadeLinhas) lerArquivo(string caminho){
            
            try{
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }catch(Exception ex){
                return (false, new string[0],0);
            }
            
        }
    }
}