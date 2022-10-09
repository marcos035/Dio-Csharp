using intro.Models;
  
  
  string opcao;

  while(true){
    Console.WriteLine("Digite sua opção:");
    Console.WriteLine("1- Cadastrar Cliente");
    Console.WriteLine("2- Buscar Cliente");
    Console.WriteLine("3- Apagar Cliente");
    Console.WriteLine("4- Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        Console.WriteLine("Cadastro de clientes");
        break;

        case "2":
        Console.WriteLine("Busca de clientes");
        break;

        case "3":
        Console.WriteLine("Apagar clientes");
        break;

        case "4":
        Console.WriteLine("Encerrar");
        Environment.Exit(0);
        break;

        default:
        Console.WriteLine("Opção invalida");
        break;
    }
  }
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  // int soma = 0, numero =0; 


// do{
//     Console.WriteLine("Digite um numero (0 para parar)");
//    numero = Convert.ToInt32(Console.ReadLine());
//    soma += numero;
// }while(numero != 0);

// Console.WriteLine($" O total da soma dos numeros digitados é: {soma}");










// int numero = 10;

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

// Console.WriteLine();















//   Calculadora p = new Calculadora();

//   p.Somar(5,7);
//   p.Dividir(10,10);
//   p.Multiplicar(5,10);
//   p.Subtrair(500, 100);
//   p.Potencia(3,3);
//   p.Seno(30);
//   p.Coseno(30);
//   p.Tan(30);
    //  p.Raiz(9);   











// bool maiorDezoito= true;
// bool menorDezoito = false;

// if(maiorDezoito || menorDezoito){

//     Console.WriteLine("Venda Liberada");

// }else{
//     Console.WriteLine("Proibido entrar");
// }
        
        
// bool presencaMin = true;

// double notaMedia = 9;

// if(presencaMin && notaMedia >=7){
// Console.WriteLine("aprovado");

// }else{
//     Console.WriteLine("reprovasco");

// }
        
        
        
        
        // Console.WriteLine("digite uma letra");
        // string letra = Console.ReadLine();

        // switch (letra)
        // {
        //     case "a":
        //     case "e":
        //     case "i":
        //     case "o":
        //     case "u":
        //         Console.WriteLine("vogal");
        //         break;
        //     default:
        //         Console.WriteLine("não é vogal");
        //         break;
        // }
    



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

