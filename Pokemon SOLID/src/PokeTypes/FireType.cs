using POKE.BL;

namespace POKE.BL {
    public class FireType : Pokemon {
        public FireType(string name) : base(name, "Fire"){}
        public override string Attack {
            get {
                var name = Name;
                return $"{name}, Flame Tower";
            }
        }
    }
}