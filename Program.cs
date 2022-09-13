// See https://aka.ms/new-console-template for more information
using exemplosMetodosConstrutoresDotNet.Models;
using System.Globalization;

DateTime data = DateTime.Now;

string dataString = "2022-09-12 17:30";

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

DateTime.TryParseExact(dataString, 
                        "yyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime data1);

// ou 

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                                        CultureInfo.InvariantCulture,DateTimeStyles.None,out DateTime data2);
                                        Console.WriteLine(data.ToShortTimeString());

if (sucesso) {
    Console.WriteLine($"Conversão com sucesso! Data: {data2}");
} else {
    Console.WriteLine($"{dataString} não é uma data válida");
}

Console.WriteLine(data);

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