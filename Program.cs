using System;

namespace sales_system_2
{
    class Program
    {

        private static Sale[] AllocationSales = new Sale[10];
        private static int SalesCount = 0;           
        //string CheaptestSeller;
        //private static int price = 0;
        private static int cheaptestPrice = 0;
        private static Sale saleCheaptes;



        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            

            // products instances 
            Product product1 = new Product("car",100);
            Product product2 = new Product("laptop", 400);
            Product product3 = new Product("desk", 155);
            Product product4 = new Product("car", 349);
            Product product5 = new Product("board",30);
            Product product6 = new Product("AirMachine", 450);
            Product product7 = new Product("bag", 150000);
            Product product8 = new Product("motorcicle", 87);
            Product product9 = new Product("car",20);
            Product product10 = new Product("jacket", 144);
            


            //sellers instances
            Seller seller1 = new Seller("Daniel", 27);
            Seller seller2 = new Seller("Andres", 30);
            Seller seller3 = new Seller("Alejandra", 24);
            Seller seller4 = new Seller("Matilde", 28);
            Seller seller5 = new Seller("Luciana", 37);
            Seller seller6 = new Seller("Carlos", 17);
            Seller seller7 = new Seller("Esteban", 67);
            Seller seller8 = new Seller("Alfonso", 83);
            Seller seller9 = new Seller("Julian", 24);
            Seller seller10 = new Seller("Mart", 14);


            //sales instances
            //  Sale sale1 = new Sale(product1, seller2, "computer hp");
            //  Sale sale2 = new Sale(product2, seller1, "laptop  Asus");
            //  Sale sale3 = new Sale(product3, seller3, "white desk");

            FillAllocationSale(new Sale(product1, seller1, "computer hp"));
            FillAllocationSale(new Sale(product2, seller2, "laptop  Asus"));
            FillAllocationSale(new Sale(product3, seller3, "green"));
            FillAllocationSale(new Sale(product4, seller4, "violet"));
            FillAllocationSale(new Sale(product5, seller5, "enormous"));
            FillAllocationSale(new Sale(product6, seller6, "beautiful"));
            FillAllocationSale(new Sale(product7, seller7, "pick"));
            FillAllocationSale(new Sale(product8, seller8, "yellow"));
            FillAllocationSale(new Sale(product9, seller9, "blue"));
            FillAllocationSale(new Sale(product10, seller10, "darkblue"));



            
            System.Console.WriteLine("the sale cheaptest is  " + getCheaptesPrice().getProduct().getPrice() + " a " +
                getCheaptesPrice().getProduct().getName() + " of seller " + getCheaptesPrice().getSeller().getName());
            
            System.Console.WriteLine("Average Produsts Price is : " + getAverageProducts() );

            System.Console.WriteLine("units of product sold: " + getProductUnit("car"));

            System.Console.WriteLine("Product most expensive is : " + getProductMostExpensive().getName() + " its price is "
                + getProductMostExpensive().getPrice());

        }

        public static void FillAllocationSale(Sale Sale)
        {
            AllocationSales[SalesCount] = Sale;
            SalesCount++;

        }

        public static Sale getCheaptesPrice()
        {
            cheaptestPrice = AllocationSales[0].getProduct().getPrice();

            for (int i = 0; i < AllocationSales.Length; i++)

            {
                for(int j = 0; j < AllocationSales.Length; j++)
                {
                    if(AllocationSales[i].getProduct().getPrice() <= AllocationSales[j].getProduct().getPrice() && 
                        AllocationSales[i].getProduct().getPrice() < cheaptestPrice)
                    {
                        cheaptestPrice = AllocationSales[i].getProduct().getPrice();
                        saleCheaptes = AllocationSales[i];
                    }
                    else { break; }
                }

            }


            return saleCheaptes;
        }
     
        // method to get the average product
        public static int getAverageProducts()
        {
            int contProducts = 0;
            int averageProducts = 0;

            for(int i = 0; i < AllocationSales.Length; i++)
            {
                contProducts = contProducts + AllocationSales[i].getProduct().getPrice();

            }

            return averageProducts = contProducts / AllocationSales.Length;

        }

        //method to calculate how many units of products were sold
        public static int getProductUnit(string productSold)
        {
            int contProductUnit = 0;

            for(int i = 0; i < AllocationSales.Length; i++)
            {
                
                    if (AllocationSales[i].getProduct().getName().Equals(productSold))
                    {
                        contProductUnit++;
                    }     
                
            }

            return contProductUnit;
        }

        public static Product getProductMostExpensive()
        {
            Product productExpensive = new Product("", 0);

            for(int i=0; i<AllocationSales.Length; i++)
            {
                if(AllocationSales[i].getProduct().getPrice() > productExpensive.getPrice())
                {
                    productExpensive = AllocationSales[i].getProduct();
                }

            }

            return productExpensive;
        }


    }
}
