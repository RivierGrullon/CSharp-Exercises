using System;

namespace POKE.BL {
    public class Pokemon {

        public Pokemon(string name, string type) {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; set;}
        public string Type { get; }
        public virtual string Attack {
            get {
                var name = Name;
                return $"{name}, attack base";
            }
        }
    }

    // public class PokemonCanFly : Pokemon {
    //     public PokemonCanFly(string name, string type) : base(name, type) {

    //     }
    //     public string CanFly {
    //         get {
    //             return "I can fly";
    //         }
    //     }
    // }
}
