using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManavManagmet
{
    class Proccess
    {
        public static void ProccessManagmet()
        {
            bool systemStatus = true;
            while (systemStatus)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("---Grocer Managmant System---");
                Console.WriteLine("-----------------------------");


                Console.WriteLine("---Please Select Proccess----\n");
                Console.WriteLine("Product Sell Proccess  (0)\n");
                Console.WriteLine("Product  Proccess      (1)\n");
                Console.WriteLine("Customer Proccess      (2)\n");
                Console.WriteLine("Order    Proccess      (3)\n");
                Console.WriteLine("Exit Managment System  (4)\n");
                Console.Write("Selected : ");
                string selectProccess = Console.ReadLine();
                switch (selectProccess)
                {
                    case "1":
                        Product();

                        break;


                    case "2":
                        Customer();
                        break;


                    case "3":
                        Order();
                        break;


                    case "4":
                        Console.WriteLine("System Closed...");
                        systemStatus = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Undefined Value , Please Return Enter Value");
                        break;
                        Console.ReadKey();
                }


            }

        }
        private static void Product()
        {
            bool productStatus = true;
            while (productStatus)
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("-------Product Process--------");
                Console.WriteLine("------------------------------\n");

                Console.WriteLine("---Please Select Proccess----\n");
                Console.WriteLine("Product List       (1)\n");
                Console.WriteLine("Product Add        (2)\n");
                Console.WriteLine("Product Delete     (3)\n");
                Console.WriteLine("Exit Proccess      (4)\n");

                Console.WriteLine("------------------------");
                Console.WriteLine("Selected: ");
                string productSelect = Console.ReadLine();
                switch (productSelect)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("-------Product List-----------");
                        Console.WriteLine("------------------------------\n");

                        if (DbContext.ProductList().Count != 0)
                        {
                            foreach (var product in DbContext.ProductList())
                            {
                                Console.WriteLine("Id        :" + product.Id);
                                Console.WriteLine("Name      :" + product.Name);
                                Console.WriteLine("Price     :" + product.Price);
                                Console.WriteLine("Stock     :" + product.Stock);
                                Console.WriteLine("----------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not Found Product");
                        }

                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("---------Add Product----------");
                        Console.WriteLine("------------------------------\n");

                        Product newProduct = new Product();
                        Console.Write("Id       :");
                        newProduct.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name     :");
                        newProduct.Name = Console.ReadLine();
                        Console.Write("Price    :");
                        newProduct.Price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Stock    :");
                        newProduct.Stock = Convert.ToInt32(Console.ReadLine());

                        DbContext.AddProduct(newProduct);
                        Console.WriteLine("Product Add Succesful");

                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("---------Delete Product----------");
                        Console.WriteLine("---------------------------------\n");

                        Console.WriteLine("----------Product List-----------");
                        Console.WriteLine("---------------------------------\n");
                        if (DbContext.ProductList().Count != 0)
                        {
                            foreach (var product in DbContext.ProductList())
                            {
                                Console.Write("Id:" + product.Id);
                                Console.WriteLine(" \t Name :" + product.Name);

                            }
                            Console.WriteLine("---------------------------------\n");

                            Console.WriteLine("Product Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            string returnStatus = DbContext.DeleteProduct(id) ?
                            "Product Delete Successful" :
                            "No Product Found To Be Deleted";
                            Console.WriteLine(returnStatus);


                        }
                        else
                        {
                            Console.WriteLine("Not Found Product");
                        }


                        break;
                    case "4":
                        Console.WriteLine("Exiting Proccess");
                        productStatus = false;
                        break;
                    default:
                        Console.WriteLine("Undefined Value , Please Return Enter Value");
                        break;

                }
                Console.ReadKey();
            }
        }
        private static void Customer()
        {
            bool customerStatus = true;
            while (customerStatus)
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("-------Customer Process-------");
                Console.WriteLine("------------------------------\n");

                Console.WriteLine("---Please Select Proccess----\n");
                Console.WriteLine("Customer List       (1)\n");
                Console.WriteLine("Customer Add        (2)\n");
                Console.WriteLine("Customer Delete     (3)\n");
                Console.WriteLine("Exit Proccess       (4)\n");
                string selectCustomer = Console.ReadLine();
                switch (selectCustomer)
                {

                    case "1":
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("-------Customer List-----------");
                        Console.WriteLine("------------------------------\n");

                        if (DbContext.CustomerList().Count != 0)
                        {
                            foreach (var customer in DbContext.CustomerList())
                            {
                                Console.WriteLine("Id        :" + customer.Id);
                                Console.WriteLine("Name      :" + customer.Name);
                                Console.WriteLine("Surname   :" + customer.Surname);
                                Console.WriteLine("Balance   :" + customer.Balance);
                                Console.WriteLine("----------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not Found Product");
                        }

                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("---------Add Customer----------");
                        Console.WriteLine("------------------------------\n");

                        Customer newCustomer = new Customer();
                        Console.Write("Id       :");
                        newCustomer.Id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name     :");
                        newCustomer.Name = Console.ReadLine();
                        Console.Write("Price    :");
                        newCustomer.Surname = Console.ReadLine();
                        Console.Write("Stock    :");
                        newCustomer.Balance = Convert.ToInt32(Console.ReadLine());

                        DbContext.AddCustomer(newCustomer);
                        Console.WriteLine("Customer Add Succesful");

                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("---------Delete Customer----------");
                        Console.WriteLine("---------------------------------\n");

                        Console.WriteLine("----------Customer List-----------");
                        Console.WriteLine("---------------------------------\n");
                        if (DbContext.CustomerList().Count != 0)
                        {
                            foreach (var customer in DbContext.CustomerList())
                            {
                                Console.Write("Id:" + customer.Id);
                                Console.WriteLine(" \t Name :" + customer.Name);

                            }
                            Console.WriteLine("---------------------------------\n");

                            Console.WriteLine("Customer Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            string deletecustomer = DbContext.DeleteCustomer(id) ?
                            "Customer Delete Successful" :
                            "No Customer Found To Be Deleted";
                            Console.WriteLine(deletecustomer);


                        }
                        else
                        {
                            Console.WriteLine("Not Found Product");
                        }


                        break;
                    case "4":
                        Console.WriteLine("Exiting Proccess");
                        customerStatus = false;
                        break;
                    default:
                        Console.WriteLine("Undefined Value , Please Return Enter Value");
                        break;

                }
                Console.ReadKey();
            }

        }
        private static void Order()
        {
            bool orderStatus = true;
            while (orderStatus)
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("-------Order Process-------");
                Console.WriteLine("------------------------------\n");

                Console.WriteLine("---Please Select Proccess----\n");
                Console.WriteLine("Order List       (1)\n");
                Console.WriteLine("Order Delete     (2)\n");
                Console.WriteLine("Exit Proccess    (3)\n");
                string orderSelect = Console.ReadLine();
                switch (orderSelect)
                {

                    case "1":
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("-------Order List-------------");
                        Console.WriteLine("------------------------------\n");

                        if (DbContext.OrderList().Count != 0)
                        {
                            foreach (var order in DbContext.OrderList())
                            {
                                Console.WriteLine("Id             :" + order.Id);
                                Console.WriteLine("Customer Name  :" + order.CustomerName);
                                Console.WriteLine("Product Name   :" + order.ProductName);
                                Console.WriteLine("Product Piece  :" + order.ProductPiece);
                                Console.WriteLine("Total Price    :" + order.TotalPrice);
                                Console.WriteLine("----------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not Found Product");
                        }

                        break;
                    
                    case "2":
                        Console.Clear();
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("---------Delete Order------------");
                        Console.WriteLine("---------------------------------\n");

                        Console.WriteLine("-----------Order List------------");
                        Console.WriteLine("---------------------------------\n");
                        if (DbContext.OrderList().Count != 0)
                        {
                            foreach (var order in DbContext.OrderList())
                            {
                                Console.Write("Id:" + order.Id);
                                Console.WriteLine(" \t Name :" + order.CustomerName);

                            }
                            Console.WriteLine("---------------------------------\n");

                            Console.WriteLine("Order Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            string deleteOrder = DbContext.DeleteOrder(id) ?
                            "Order Delete Successful" :
                            "No Order Found To Be Deleted";
                            Console.WriteLine(deleteOrder);


                        }
                        else
                        {
                            Console.WriteLine("Not Found Product");
                        }


                        break;
                    case "3":
                        Console.WriteLine("Exiting Proccess");
                        orderStatus = false;
                        break;
                    default:
                        Console.WriteLine("Undefined Value , Please Return Enter Value");
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}



