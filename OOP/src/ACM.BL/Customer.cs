using System;
using System.Collections.Generic;
using Acme.common;

namespace ACM.BL
{
    public class Customer: Entitybase, ILoggable
    {
        public Customer(): this(0)
        {
            
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName {get; set; }

        public string EmailAddress {get; set; }

        static public int InstanceCount { get; set; }

        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress}";
    }
}
