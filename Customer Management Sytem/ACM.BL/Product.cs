
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL {
    public class Product : EntityBase, ILoggable{
        public Product() {

        }

        public Product(int productID) => ProductID = productID;

        public int ProductID {get ; private set; }
        private string _productName;
        public string ProductName {
            get {

                return _productName.InsertSpaces();
            }
            set {
                _productName = value;
            } }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public string Log() => $"{ProductID}: {ProductName} Detail: {Description} Status: {EntityState.ToString()}";

        ///<summary>
        /// Retrieves one product
        ///</summary>
        public Product Retrieve(int productID) {

            return new Product(productID);
        }

        ///<summary>
        /// Retrieves all Products
        ///</summary>
        public List<Product> Retrieve() {

            return new List<Product>();
        }
        ///<summary>
        /// Save the current product
        ///</summary>
        public bool Save() {

            return true;
        }

        public override bool Validate() {
        var isValid = true;

        if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
        if (CurrentPrice == null ) isValid = false;

        return isValid;
    }
    }
}