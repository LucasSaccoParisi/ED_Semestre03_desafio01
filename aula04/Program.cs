using System;
// - Crie pelo menos **2 treinadores**

List<Pokemon> PokemonsWalter = new List<Pokemon>();
List<Pokemon> PokemonsJesse = new List<Pokemon>();

Treinador Walter = new Treinador("Walter White", PokemonsWalter);

Treinador Jesse = new Treinador("Jesse Pinkman", PokemonsJesse);

PokemonFogo Charmander = new PokemonFogo("Charmander", 39, 52, 43);
PokemonGrama Bulbasaur = new PokemonGrama("Bulbasaur", 45, 49, 49);

Walter.AdicionarPokemon(Charmander);
Walter.AdicionarPokemon(Bulbasaur);

Walter.ListarPokemons();

Console.Write("\n");

PokemonAgua Squirtle = new PokemonAgua("Squirtle", 44, 48, 65);

Jesse.AdicionarPokemon(Squirtle);
Jesse.AdicionarPokemon(Charmander);

Jesse.ListarPokemons();

// Batalha

Walter.EscolherPokemon(0);
Jesse.EscolherPokemon(0);

PokemonsWalter[0].Atacar(PokemonsJesse[0]);
