using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system_2
{
    class Product
    {
        private String Name;
        private int Price;

        public Product(String Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public void setName(String Name)
        {
            this.Name = Name;
        }

        public String getName()
        {
            return this.Name;
        }
        public void setPrice(int Price)
        {
            this.Price = Price;
        }

        public int getPrice()
        {
            return this.Price;
        }

    }
}
