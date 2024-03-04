using Newtonsoft.Json;
using System;
//using System.Text.Json;
using System.Collections.Generic;

namespace JsonDemo
{
    class Program
    {
        static void Main()
        {
            var list = new List<Customer>() { 

            new Customer {
                CustomerName = "john",
                Email = "john@123",
                Age = 33,
                Sales = 2000,
                PurchaseDate = new DateTime(2023, 4, 15) },
            new Customer
            {
                CustomerName = "peter",
                Email = "peter@123",
                Age = 30,
                Sales = 3000,
                PurchaseDate = new DateTime(2024, 5, 15)
            },
            new Customer
            {
                CustomerName = "Nandu",
                Email = "Nandu@123",
                Age = 26,
                Sales = 1500,
                PurchaseDate = new DateTime(2024, 2, 15)
            }
        };

            Customer customer = new Customer
            {
                CustomerName = "Nandita",
                Email = "Nandita@123",
                Age = 24,
                Sales = 4000,
                PurchaseDate = new DateTime(2024, 2, 15)
            };

            //string Json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
            //Console.WriteLine(Json);

            string json = JsonConvert.SerializeObject(customer,Formatting.Indented);

            Console.WriteLine(json);
            
            //var newcustomer = JsonConvert.DeserializeObject<List<Customer>>(json);
            Customer cust = JsonConvert.DeserializeObject<Customer>(json);

            //Console.WriteLine(cust);

        }

        //[Serializable]
        class Customer
        {
            public string CustomerName { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            public double Sales { get; set; }
            public DateTime PurchaseDate { get; set; }


        }
    }
}
