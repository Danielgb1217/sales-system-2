using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system_2
{
    class Sale
    {

        private Product product;
        private Seller seller;
        private String comments;
       

        public Sale(Product product, Seller seller, String comments)
        {
            this.product = product;
            this.seller = seller;
            this.comments = comments;
        }

        public void setProduct(Product product)
        {
            this.product = product;
        }
        public Product getProduct()
        {
            return this.product;
        }
        public void setSeller(Seller seller)
        {
            this.seller = seller;
        }
        public Seller getSeller()
        {
            return this.seller;
        }
        public void setComments(String comments)
        {
            this.comments = comments;
        }
        public String getComments()
        {
            return this.comments;
        }
    }
}
