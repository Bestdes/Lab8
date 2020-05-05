using System;
using System.Collections.Generic;

namespace UMLClassLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();
            listOfPersons.Add(new Student("Sam I Am", "45 Young St., New Haven, CT, 05611", "Fine Arts", 1, 720.59));
            listOfPersons.Add(new Student("Michael", "78 Westwood Rd., Grand Raoids, MI, 49546", "Psychology", 1, 827.67));
            listOfPersons.Add(new Student("Justin", "325 Grant St., Holmdel, NJ, 42883", "Finance", 2, 1189.33));
            listOfPersons.Add(new Staff("Staff Sergeant", "1221 Military Way, Philadelphia, PA, 92821", "Army", 45000.11));
            listOfPersons.Add(new Staff("Brigadier General", "1221 Military Way, Philadelphia, PA, 92821", "Army", 125477.27));

            DisplayPersons(listOfPersons);
            AddPersonToList(listOfPersons);

        }

        public static void DisplayPersons(List<Person> personList)
        {
            foreach (Person person in personList)
            {
                person.ToString();
            }
        }

        public static void AddPersonToList(List<Person> personList)
        {
            Console.WriteLine("\nWhat type of person do you want to add to the list?");
            Console.WriteLine("----Enter Staff or Student");
            string input = ReadAndReturnInput();
            bool isValidPerson = false;

            while (!isValidPerson)
            {
                if(input.ToLower() == "staff")
                {
                    Staff staff = new Staff();
                    personList.Add(PromptReadandReturnStaff(staff));
                    Console.WriteLine($"\n{staff.Name} was succesfully added to the list.");
                    isValidPerson = true;
                }
                else if(input.ToLower() == "student")
                {
                    Student student = new Student();
                    personList.Add(PromtReadAndReturnStudent(student));
                    Console.WriteLine($"\n{student.Name} was succesfully added to the list.");
                    isValidPerson = true;
                }
                else
                {
                    Console.WriteLine("Invalid person type. Try again.");
                    input = ReadAndReturnInput();
                }
            }
            DisplayPersons(personList);

        }

        public static string ReadAndReturnInput()
        {
            return Console.ReadLine();
        }

        public static Staff PromptReadandReturnStaff(Staff staff)
        {
            Console.WriteLine("\nWhat is the name of the Staff member?");
            staff.Name = ReadAndReturnInput();
            Console.WriteLine($"\nWhat is {staff.Name}'s address?");
            staff.Address = ReadAndReturnInput();
            Console.WriteLine($"\nWhere did {staff.Name} attend school?");
            staff.School = ReadAndReturnInput();
            Console.WriteLine($"\nHow much does {staff.Name} get paid?");
            string input = ReadAndReturnInput();
            while(!ValidateNumInput(input))
            {
                Console.WriteLine("\nInvalid input please make sure to enter a number!");
                input = ReadAndReturnInput();
            }
            staff.Pay = double.Parse(input);
            return staff;
        }

        public static Student PromtReadAndReturnStudent(Student student)
        {
            Console.WriteLine("\nWhat is the name of the Student?");
            student.Name = ReadAndReturnInput();
            Console.WriteLine($"\nWhat is {student.Name}'s address?");
            student.Address = ReadAndReturnInput();
            Console.WriteLine($"\nWhat is the {student.Name} studying in school?");
            student.Program = ReadAndReturnInput();
            Console.WriteLine($"\nWhat year of schooling is {student.Name} currently in?");
            string yearInput = ReadAndReturnInput();
            while (!ValidateNumInput(yearInput))
            {
                Console.WriteLine("\nInvalid input please make sure to enter a number!");
                yearInput = ReadAndReturnInput();
            }
            student.Year = int.Parse(yearInput);
            Console.WriteLine($"\nHow much does {student.Name} owe?");
            string feeInput = ReadAndReturnInput();
            while (!ValidateNumInput(feeInput))
            {
                Console.WriteLine("\nInvalid input please make sure to enter a number!");
                feeInput = ReadAndReturnInput();
            }
            student.Fee = double.Parse(feeInput);

            return student;
        }

        public static bool ValidateNumInput(string toBeValidated)
        {
            bool isANum = false;
            int confirmedInt;
            if (int.TryParse(toBeValidated, out confirmedInt))
            {
                isANum = true;
                return isANum;
            }
            return isANum;
        }
    }
}
