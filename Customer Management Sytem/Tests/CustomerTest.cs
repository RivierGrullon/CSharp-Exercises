using System.Linq.Expressions;
using System.Reflection;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests {
    [TestClass]
    public class CustomerTest {
        [TestMethod]
        public void FullName() {
            //arrange
            Customer customer = new Customer();
            customer.EmailAddress = "rivier59@outlook.es";
            customer.LastName = "Grullon";
            customer.FirstName = "Rivier";

            //act
            var expected = "Grullon, Rivier";
            var actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid() {
            //arrange
            Customer customer = new Customer();
            customer.EmailAddress = "rivier59@outlook.es";
            customer.LastName = "Grullon";
            customer.FirstName = "Rivier";

            //act
            var expected = true;
            var actual = customer.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
