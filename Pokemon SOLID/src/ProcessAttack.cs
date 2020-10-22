using System.Collections.Generic;

namespace POKE.BL {
    public class ProcessAttack {
    public List<Pokemon> AllPokemonAttack(List<Pokemon> pokemonList) {
        /*
            En este caso solo basta con recibir el listado de pokemons
            para porder ejecutar un ataque, ya que cada elemento del listado
            cuenta con su propio ataque.
        */
        var pokeList = new List<Pokemon>();
        foreach(var pokemon in pokemonList) {
            pokeList.Add(pokemon);
        }
        return pokeList;
    }
    }
}