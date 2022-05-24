using System;
using System.Collections.Generic;
using System.Text;

namespace CPSC1012_Exercise07_Youngjae_Lee
{
    public class Product
    {
        //fields
        private string _name;
        private string _description;
        private double _price;

        //no-parameter constructor
        public Product()
        {

        }

        //parameterized constructor
        public Product(string productName, string productDescription, double productPrice)
        {
            _name = productName;
            _description = productDescription;
            _price = productPrice;
        }

        //declare name property
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        //declare description property
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        //declare price property
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
    }
}
