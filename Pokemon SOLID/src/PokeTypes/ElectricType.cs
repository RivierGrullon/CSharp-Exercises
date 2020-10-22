using System;
using POKE.BL;

namespace POKE.BL {
    public class ElectricType : Pokemon {

        public ElectricType(string name) : base(name, "Electric"){

        }
        public override string Attack {
            get {
                var name = Name;
                return $"{name}, Thunder";
            }
        }
    }
}
