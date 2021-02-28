using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system_2
{
    class Seller
    {
        private String Name;
        private int Age;
        
        public Seller( String Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void setName(String Name)
        {
            this.Name = Name;
        }

        public String getName()
        {
            return this.Name;
        }
        public void setAge(int Age)
        {
            this.Age = Age;
        }

        public int getAge()
        {
            return this.Age;
        }

    }
}
