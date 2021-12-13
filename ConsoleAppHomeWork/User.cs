using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWork
{
    internal class User : IComparable
    {
        string name;
        string lname;
        int yearBorn;
        string email;

        public User(string name, string lname, int yearBorn, string email)
        {
            this.name = name;
            this.lname = lname;
            this.yearBorn = yearBorn;
            this.email = email;
        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Lname { get { return this.lname; } set { this.lname = value; } }
        public int YearBorn { get { return this.yearBorn; } set { this.yearBorn = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }

        public int CompareTo(object obj) { User p = (User)obj; if (this.yearBorn < p.yearBorn) return -1; if (this.yearBorn > p.yearBorn) return 1; return 0; }
        public void Print()
        {
            Console.WriteLine($"{this.name},{this.lname} , {this.YearBorn} , {this.Email}");
        }

    }

    //public User(string name, string lname, int yearBorn, string email)
    //{
    //    this.name = name;
    //    this.lname = lname;
    //    this.yearBorn = yearBorn;
    //    this.email = email;
    //}



}
