using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CanBan
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Address;

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            Person person = new Person("Khoa", 21, "149 Thanh My Loi");
            person.DisplayInfo();
        }
    }
}
