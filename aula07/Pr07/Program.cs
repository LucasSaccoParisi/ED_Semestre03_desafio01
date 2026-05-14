using System;

bool exit = false;

do{
  Console.WriteLine("===MENU===");
  Console.WriteLine("1: Nova Simulação \n ==ou== \n 2: Sair\n>> ");
  string input = Console.ReadLine();
  
  if(input == "2"){
    Console.WriteLine("Tchau!");
    exit = true;
    break;
  } else if(input == "1"){
    Console.WriteLine("===Digite a quantidade de amostras===\n>> ");
    int QuantAmostrasInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("===Digite a quantidade de elementos para cada amostra: 6===\n>>");
    int QuantElementosInput = Convert.ToInt32(Console.ReadLine());
    
    Amostras InputResultado = new Amostras(QuantAmostrasInput, QuantElementosInput);
    InputResultado.CriarArvores();

    Console.WriteLine($"===Experimento com A = {QuantAmostrasInput} e N = {QuantElementosInput}===");
    InputResultado.CalcularMedia();
  }

}while(exit == false);
