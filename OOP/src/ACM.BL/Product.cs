using Acme.common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Product: Entitybase, ILoggable
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public string Log() =>
            $"{ProductId}: {ProductName} Detail: {ProductDescription}";
    }
}