using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWork
{
    internal class Student:User
    {
        public int great;

        Student(string name, string lname, int yearBorn, string email, int great):base(name,lname,yearBorn,email)
        {
            this.great = great;
        }
        //public void PrintAll()
        //{
        //    Console.WriteLine($"{base.Print()},{this.great}");
        //}
    }
}
