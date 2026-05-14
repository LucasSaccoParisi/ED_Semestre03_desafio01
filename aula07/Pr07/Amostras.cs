using System;


// Tarefa da classe Amostras: Fazer uma arvore BST e uma AVL
// ou seja: A(1) = BST & AVL / 2 arvores ; A(2) = 2BST & 2AVL / 4 arvores

public class Amostras{
  public int Amostr { get; set; }
  public int AmosNo { get; set; }

  public Amostras(int amostr, int amosNo){
    Amostr = amostr;
    AmosNo = amosNo;
  }

  public void CriarArvores(){
    int contador = 0;

    Random rnd = new Random();
    var numeros = new HashSet<int>();
    
    while(numeros.Count < this.AmosNo)
      numeros.Add(rnd.Next(0, 10));

    for(int i = 0; i < this.Amostr; i++){
      BST AmostraBinaria = new BST();
      AVL AmostraBalanceada = new AVL();
      contador += 2;
      
      foreach(var num in numeros){
        AmostraBinaria.Insert(num);
        AmostraBalanceada.Insert(num);
      }
    }
  }

  public void CalcularMedia(){
    int mediaBinaria = (this.AmosNo - 2);
    decimal mediaBalenceada = ((decimal)this.AmosNo / (decimal)this.Amostr);

    decimal mediaGeral = ((decimal)mediaBinaria + mediaBalenceada)/2;
    
    /*
      > Altura média geral:     3.5
      > Altura média BST comum: 4
      > Altura média AVL:       3
    */

    Console.WriteLine($"""
        Altura média geral: {mediaGeral}
        Altura média BST comum: {mediaBinaria} 
        Altura média AVL: {mediaBalenceada}
        """);
  }
}
