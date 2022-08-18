using exemploFundamentos_dotnet.Models;



int[] ArrayInteiros = new int[3];

ArrayInteiros[0] = 72;
ArrayInteiros[1] = 73;
ArrayInteiros[2] = 43;

Console.WriteLine("percorrendo com array com FOR");
for(int contador = 0; contador < ArrayInteiros.Length; contador++) {
    Console.WriteLine($"Posição N {contador}  - {ArrayInteiros[contador]}");
}

Console.WriteLine("percorrendo o array com FOREACH");

int contadorForeach = 0;
foreach(int valor in ArrayInteiros){
    Console.WriteLine($"Posicao N {contadorForeach} - {valor}");
    contadorForeach++;
    Console.WriteLine(valor);
}
//for (int i = 0; i < ArrayInteiros.Length; i++){
//    Console.WriteLine($"Posicao N {i} - {ArrayInteiros[i]}");
//}

/*string opcao;
bool exibirMenu = true;

while (exibirMenu) {
    Console.Clear();
    Console.WriteLine("Digite a sua opcao");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao) {
        case "1":
            Console.WriteLine("Cadstro de cliente");
            break;

        case "2":
            Console.WriteLine("Buscar cliente");
            break;
        
        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("opção invalida!!");
            break;
    }
}
*/

/*Calculadora calc = new Calculadora();

calc.Seno(19);
calc.Coseno(30);
calc.Tangente(20);



bool PresencaMinima = true;
double media = 7.0;

if(PresencaMinima && media >= 7) {
    Console.WriteLine("aprovado");
} else {
    Console.WriteLine("reprovado");
}

bool MaiorDeIdade = true;
bool AutorizacaoResponsavel = false;

if (MaiorDeIdade || AutorizacaoResponsavel) {
    Console.WriteLine("Entrada liberada");
} else {
    Console.WriteLine("Entrada não liberada");
}






Console.WriteLine("digite uma letras");
    string letra = Console.ReadLine();

    switch(letra) {
        case"a":    
        case"e": 
        case"i":
        case"o":
        case"u":
        Console.WriteLine("vogal");
        break;

        default: 
        Console.WriteLine("não é vogal");
        break;
    }


















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

int quantidadeEstoque = 10;

int quantidadeCompra = 4;

if (quantidadeCompra == 0) {
    Console.WriteLine("quantidade invalida");
}
else if (quantidadeEstoque >= quantidadeCompra) {
    Console.WriteLine("venda realizada com sucesso");
} else {
    Console.WriteLine("Não temos a quantidade desejada em estoque");
}

*/