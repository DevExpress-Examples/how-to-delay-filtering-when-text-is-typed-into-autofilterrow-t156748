using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFilterRowPostDelay
{
    public class Data
    {
        private static string[] FirstNames = new string[] 
        {"Ann", "Peter",  "Rose", "Lily", "Tom", "Jack", "Holly", "Poul"};

        private static string[] LastNames = new string[] 
        {"Red", "Blue", "Orange", "White", "Yellow", "Black"};

        private static Random gen = new Random();

        public static List<Customer> DataList
        {
            get
            {
                List<Customer> data = new List<Customer>();
                for (int i = 0; i < 20; i++)
                {
                    data.Add(new Customer() { Id = i, FirstName = FirstNames[gen.Next(8)], LastName = LastNames[gen.Next(6)] });
                }
                return data;
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
