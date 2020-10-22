using System.ComponentModel;

namespace POKE.BL {
    public class Charizard : FireType, IPokeFly{
        public Charizard(string name) : base(name){}

        public string CanFly() {
            return "I can fly";
        }
    }
}