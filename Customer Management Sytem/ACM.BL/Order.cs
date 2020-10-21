using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL {
    public class Order : EntityBase, ILoggable {
        public Order(): this(0) {
        }

        public Order(int orderID) {
            this.OrderID = orderID;
            this.OrderItems = new List<OrderItem>();
        }

        public int CustomerID { get; set; }

        public int ShippingAddressID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
    public string Log() =>
        $"{OrderID}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";

        ///<summary>
        /// Retrieves one order
        ///</summary>

        public override bool Validate() {
        var isValid = true;

        if (OrderDate == null) isValid = false;

        return isValid;
    }
    }
}