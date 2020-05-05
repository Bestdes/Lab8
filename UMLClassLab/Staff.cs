using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClassLab
{
    class Staff : Person
    {
        private string school;
        private double pay;
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public Staff()
        {
        }

        public override string ToString()
        {
            string output = $"Staff[Person[name = {Name}, address = {Address}, school = {School}, pay = {Pay}]";
            Console.WriteLine(output);
            return output;
        }
    }
}
