using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRUD
{
    internal class Customer
    {
        public int ID { get; set; } //PrimaryKey
        public string Name { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public long PhoneNumber { get; set; }
        public int Budget { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Address: {Adress}, Email: {Email}, Budget:  ${Budget}, Phone Number: {PhoneNumber} \n";
        }

    }
}
