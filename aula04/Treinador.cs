using System;

public class Treinador{
  public string Nome { get; set; }
  List<Pokemon> Pokemons = new List<Pokemon>();

  public Treinador(string nome, List<Pokemon> pokemons){
    Nome = nome;
    Pokemons = pokemons;
  }

  public void AdicionarPokemon(Pokemon p){
    this.Pokemons.Add(p);
  }

  public void ListarPokemons(){
    Console.WriteLine($"===Pokemons de {this.Nome}===");
    foreach(Pokemon p in this.Pokemons){
      Console.WriteLine(p.Nome);
    }
  }

  public void EscolherPokemon(int indice){
    Console.WriteLine($"\n==={this.Nome} Escolheu: " + this.Pokemons[indice].Nome + "===");
  }
}
