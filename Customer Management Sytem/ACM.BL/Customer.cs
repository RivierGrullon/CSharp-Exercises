using Acme.Common;
using System.Collections.Generic;

namespace ACM.BL {
    public class Customer : EntityBase, ILoggable {

        public int ID { get; private set; }

        public Customer(int iD)
        {
            this.ID = iD;
            this.AddressList = new List<Address>();
        }

        public Customer(): this(0) {



        }

        public List<Address> AddressList { get; set; }
    public string Log() =>
      $"{ID}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        public string EmailAddress { get; set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName)) {
                    if (!string.IsNullOrWhiteSpace(fullName)) {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        ///<summary>
        /// Validates the customer data
        ///</summary>
        public override bool Validate() {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
        public static int InstanceAccount { get; set; }

    }


}
