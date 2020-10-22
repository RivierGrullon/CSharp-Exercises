using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POKE.BL;

namespace PokemonTests
{
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void ElectricPokemon() {
            //arrange
            var jolteon = new ElectricType("Jolteon");
            var actual = jolteon.Type;
            //act
            var expect = "Electric";
            Console.WriteLine(actual);

            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void WaterPokemon() {
            //arrange
            var Vaporeon = new WaterType("Vaporeon");
            var actual = Vaporeon.Type;
            //act
            var expect = "Water";
            Console.WriteLine(Vaporeon.Attack);

            Assert.AreEqual(Vaporeon.Attack, "Vaporeon, Water Pistol");
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void ProcessAttackTest() {
            //arrange
            var attacks = new ProcessAttack();
            var pokeList = new List<Pokemon>();
            pokeList.Add(new ElectricType("Jolteon"));
            pokeList.Add(new WaterType("Vaporeon"));
            pokeList.Add(new FireType("Flareon"));
            var actual = attacks.AllPokemonAttack(pokeList);
            string[] expect = {"Electric", "Water", "Fire"};

            for(var i = 0; i < pokeList.Count; i ++) {

                Assert.AreEqual(expect[i], actual[i].Type); 
            }
            //act


        }

        [TestMethod]
        public void CanFlyTest() {
            //arrange
            var charizard = new Charizard("el pepe");
            var actual = charizard.CanFly();
            var expect = "I can fly";

            Assert.AreEqual(expect, actual);
        }
    }
}
