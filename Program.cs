using exemploFundamentos_dotnet.Models;
    // string apresentacao = "ola, bem vindo";
    // int quantidade = 1;
    // double altura = 1.80;
    // decimal preco = 1.80M;

    // Console.WriteLine(apresentacao);
    // Console.WriteLine(quantidade);
    // Console.WriteLine(preco);
    // Console.WriteLine(altura);


//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "BRUNO";
//pessoa1.Idade = 19;
//pessoa1.Apresentar();


DateTime dataAtual = DateTime.Now.AddYears(1);
Console.WriteLine(dataAtual);


int a = 10;
int b = 10;

int c = a + 5;

int inteiro = 5;
string d = inteiro.ToString();


double f = 4 / (2 + 2);

Console.WriteLine(a);


int.TryParse(d, out b);

Console.WriteLine(b);
Console.WriteLine("conversão realizada com sucesso");
