// See https://aka.ms/new-console-template for more information
using exemplosMetodosConstrutoresDotNet.Models;


Pessoa p1 = new Pessoa();
p1.Nome = "Bruno";
p1.Sobrenome = "Mendonça Gusmão";

Pessoa p2 = new Pessoa();
p1.Nome = "Eduardo";
p1.Sobrenome = "Queiroz";

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