// - 🔥 Fogo: causa +2 de dano

public class PokemonFogo : Pokemon{
  public PokemonFogo(string nome, int vida, int ataque, int defesa) 
    : base(nome, PokemonTipo.Fogo, vida, ataque, defesa) { }

  public override void Atacar(Pokemon Alvo){
    int dano = this.Ataque - Alvo.Defesa;
    if (dano < 1)
      dano = this.Ataque;
    Alvo.Vida -= (dano + 2);

    Console.WriteLine($"\n==={this.Nome} fez {dano} de dano! {Alvo.Nome} agora está com {Alvo.Vida} de Vida!===");

    if(Alvo.Vida <= 0)
      Console.WriteLine($"==={this.Nome} Ganhou!===\n");
  }
}
