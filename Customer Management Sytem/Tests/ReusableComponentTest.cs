
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Common {
    [TestClass()]
    public class ReusableComponentTest {

        [TestMethod]
        public void StringHandlerTest() {
            //arrange

            var source = "ElPepe";
            var expected = "El Pepe";

            //act
            var actual = StringHandler.InsertSpaces(source);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringHandlerTest2() {
            //arrange


            var source = "El Pepe";
            var expected = "El Pepe";

            //act
            var actual = StringHandler.InsertSpaces(source);

            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}