// See https://aka.ms/new-console-template for more information
using exemplosMetodosConstrutoresDotNet.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 82.40M;

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR")));

string numero1 = "18";
string numero2 = "19";

string resultado = numero1 + numero2;

Console.WriteLine(resultado);

Pessoa p1 = new Pessoa(nome: "Artur",sobrenome: "Queiroz");

Pessoa p2 = new Pessoa(nome: "Bruno", sobrenome:"Gusmão");


Curso cursoDoIngles = new Curso();
cursoDoIngles.Nome = "ingles";
cursoDoIngles.Alunos = new List<Pessoa>();

cursoDoIngles.AdicionarAluno(p1);
cursoDoIngles.AdicionarAluno(p2);
cursoDoIngles.ListarAlunos();


/*
Pessoa p1 = new Pessoa();
p1.Nome = "Bruno";
p1.Sobrenome = "Mendonça Gusmão";
p1.Idade = 19;
p1.Apresentar();
*/
//TODO: Implementar metodos//