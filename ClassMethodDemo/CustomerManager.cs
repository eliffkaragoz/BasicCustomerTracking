using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        List<Customer> addedCustomers = new List<Customer>();
        public void CustomerAdd(Customer customer)
        {
            addedCustomers.Add(customer);
        }
        public void CustomerListing()
        {
            foreach (var customer in addedCustomers)
            {
                Console.WriteLine(customer.Id + ". Customer : " + customer.Name + " " + customer.Surname);
            }
        }
        public void CustomerDelete(Customer customer)
        {
            addedCustomers.Remove(customer);
        }
    }
}
