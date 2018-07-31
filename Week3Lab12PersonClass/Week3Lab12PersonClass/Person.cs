using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Lab12PersonClass
{
    public class Person
    {
        public Person(string name,string address )
        {
            Name = name;
            Address = address;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetAddress()
        {
            return Address;
        }
        private string Name { get; set; }
        private string Address { get; set; }



        public override string ToString()
        {
            return $"Person = [Name = {Name}, Address = {Address}]";
        }
    }

}
