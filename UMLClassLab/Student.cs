using System;
using System.Collections.Generic;
using System.Text;

namespace UMLClassLab
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public Student()
        {
        }

        public override string ToString()
        {
            string output = $"Student[Person[name = {Name}, address = {Address}, program = {Program}, year = {Year}]";
            Console.WriteLine(output);
            return output;
        }
    }
}
