namespace POKE.BL {
    public class Blastoise : WaterType, IPokeSwim {
        public Blastoise(string name) : base(name){}

        public string CanSwim()
        {
            throw new System.NotImplementedException();
        }
    }
}