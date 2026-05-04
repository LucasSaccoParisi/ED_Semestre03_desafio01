public enum PokemonTipo { Normal, Fogo, Agua, Grama }

public abstract class Pokemon{
  public String Nome { get; set; }
  public PokemonTipo Tipo { get; set; }
  public int Vida { get; set; }
  public int Ataque { get; set; }
  public int Defesa { get; set; }

  public Pokemon(String nome, PokemonTipo tipo, int vida, int ataque, int defesa){
    Nome = nome;
    Tipo = tipo;
    Vida = vida;
    Ataque = ataque;
    Defesa = defesa;
  }

  public void ExibirStatus(Pokemon Alvo){
    Console.WriteLine($"==={Nome}===");
    Console.WriteLine($"--> Tipo: {Tipo}");
    Console.WriteLine($"--> Total de Vida: {Vida}");
    Console.WriteLine($"--> Ataque: {Ataque}");
    Console.WriteLine($"--> Defesa: {Defesa}");
  }

  public virtual void Atacar(Pokemon Alvo){
    int dano = this.Ataque - Alvo.Defesa;
    if (dano < 1)
      dano = this.Ataque;
    Alvo.Vida -= dano;

    Console.WriteLine($"{this.Nome} fez {dano} de dano! {Alvo.Nome} agora está com {Alvo.Vida} de Vida!");
    
    if(Alvo.Vida <= 0)
      Console.WriteLine($"==={this.Nome} Ganhou!===\n");
  }

}
