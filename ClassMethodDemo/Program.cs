using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Jason";
            customer1.Surname = "Allen";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Kevin";
            customer2.Surname = "Bell";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Patricia";
            customer3.Surname = "Carter";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);
            customerManager.CustomerListing();
            Console.WriteLine("New List --------------------");
            customerManager.CustomerDelete(customer1);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerListing();

        }
        
    }
}
