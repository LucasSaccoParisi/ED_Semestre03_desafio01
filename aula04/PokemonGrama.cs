// - 🌱 Grama: 20% de chance de ataque crítico

public class PokemonGrama : Pokemon {
  public PokemonGrama(string nome, int vida, int ataque, int defesa) 
    : base(nome, PokemonTipo.Grama, vida, ataque, defesa) { }
  
  public override void Atacar(Pokemon Alvo){
    int dano = (this.Ataque + 2) - Alvo.Defesa;
    if (dano < 1)
      dano = this.Ataque;

    Alvo.Vida -= dano;
    this.Vida += 2;
    
    Console.WriteLine($"{this.Nome} fez {dano} de dano! {Alvo.Nome} agora está com {Alvo.Vida} de Vida!");
    
    if(Alvo.Vida <= 0)
      Console.WriteLine($"==={this.Nome} Ganhou!===\n");
  }
}
