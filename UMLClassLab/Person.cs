using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClassLab
{
    class Person
    {

        private string name;
        private string address;

        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            string output = $"Person[name = {Name}, address = {Address}]";
            Console.WriteLine(output);
            return output;
        }
    }
}
