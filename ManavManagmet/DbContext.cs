using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavManagmet
{
    static class DbContext
    {
        private static List<Product> _products = new List<Product>();
        private static  List<Customer> _customer = new List<Customer>();
        private static  List<Order> _order = new List<Order>();

        public static  List<Product> ProductList()
        {
            
            return _products;

        }
        public static List<Customer> CustomerList()
        {
            return _customer;
        }
        public static List<Order> OrderList()
        {
            return _order;
        }

        public static void AddProduct(Product product) 
        {
            _products.Add(product);
        }
        public static  void AddCustomer(Customer customer)
        {
            _customer.Add(customer);
        }
        public static void AddOrder(Order order) 
        {
            _order.Add(order);
        }
        public static bool DeleteProduct(int id)
        {
            bool deleteStatus = false;
            foreach (var product in _products.ToList())
            {
                if (product.Id==id)
                {
                    _products.Remove(product);
                    deleteStatus = true;
                }
            }
            return deleteStatus;
        }public static bool DeleteCustomer(int id)
        {
            bool deleteCustomer = false;
            foreach (var customer in _customer.ToList())
            {
                if (customer.Id==id)
                {
                    _customer.Remove(customer);
                    deleteCustomer = true;
                }
            }
            return deleteCustomer;
        }public static bool DeleteOrder(int id)
        {
            bool deleteOrder = false;
            foreach (var order in _order.ToList())
            {
                if (order.Id==id)
                {
                    _order.Remove(order);
                    deleteOrder = true;
                }
            }
            return deleteOrder;
        }


    }
}
