// See https://aka.ms/new-console-template for more information
using exemplosMetodosConstrutoresDotNet.Models;
using System.Globalization;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados) {
    Console.WriteLine($"Chave:{item.Key}, valor: {item.Value}");
}

estados.Remove("SP");

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave)) {
    Console.WriteLine($"Valoe existente: {chave}");
}
else {
    Console.WriteLine($"valor não existe.É seguro adicionar a chave: {chave}");
}
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(10);

foreach(int item in pilha) {
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");


new exemploExcecao().Metodo1();

try {

string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach(string linha in linhas) {
    Console.WriteLine(linha);
}
}

catch(FileNotFoundException ex) {
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo.Arquivo não encontrado no sistema. {ex.Message}");
}
catch(DirectoryNotFoundException ex) {
    Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado no sistema." + ex.Message);
}


catch (Exception ex) {
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
} finally {
    Console.WriteLine("Chegou até aqui");
}

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