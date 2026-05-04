// - 💧 Água: recupera 2 de vida após atacar

public class PokemonAgua : Pokemon {
  public PokemonAgua(string nome, int vida, int ataque, int defesa) 
    : base(nome, PokemonTipo.Agua, vida, ataque, defesa) { }
  
  public override void Atacar(Pokemon Alvo){
    int dano = this.Ataque - Alvo.Defesa;
    if (dano < 1)
      dano = this.Ataque;

    Alvo.Vida -= dano;
    this.Vida += 2;
    
    Console.WriteLine($"{this.Nome} fez {dano} de dano! {Alvo.Nome} agora está com {Alvo.Vida} de Vida!");
    Console.WriteLine($"{this.Nome} recebeu 2+ de vida: {this.Vida}");
    
    if(Alvo.Vida <= 0)
      Console.WriteLine($"==={this.Nome} Ganhou!===\n");
  }
}
