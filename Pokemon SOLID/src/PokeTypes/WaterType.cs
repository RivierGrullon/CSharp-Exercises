using System;
using System.IO.Pipes;

namespace POKE.BL {
    public class WaterType : Pokemon {
        public WaterType(string name) : base(name, "Water"){}
        public override string Attack {
            get {
                var name = Name;
                return $"{name}, Water Pistol";
            }
        }
    }

}