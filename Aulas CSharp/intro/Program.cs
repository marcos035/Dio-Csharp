using intro.Models;
  
        Console.WriteLine("digite uma letra");
        string letra = Console.ReadLine();

        switch (letra)
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                Console.WriteLine("vogal");
                break;
            default:
                Console.WriteLine("não é vogal");
                break;
        }
    











// int qtdeCompra = -10;

// int qtdeEstoque = 9;

// bool venda = qtdeEstoque>=qtdeCompra && qtdeEstoque >0;
//  if(qtdeCompra == 0 || qtdeCompra <1){
// Console.WriteLine("Venda invalida");}
// else if(venda){
//     Console.WriteLine("A venda foi realizada");
// }
// else{
//     Console.WriteLine("Cabou tudo meu fi, não temos "+ qtdeEstoque +" produtos em estoque");
// }

// int inteiro = 5;
// string a = inteiro.ToString();
// string b = inteiro.ToString();

// Console.WriteLine(a);

// int a = Convert.ToInt32("5");

// Console.WriteLine(a);

// int b = int.Parse("5");


// int a = 10; 
// int b = 20;

// int c = a+b;

// c += 5;
// // c= c+5;

// Pessoa p = new Pessoa();

//  p.Nome= "Marcos";
//  p.Idade = 23;

//  p.Apresentar();

//  p.Cidade= "São Sebastiâo do Paraiso";
//  p.Habitantes = "80.000";

//  p.Morar();

