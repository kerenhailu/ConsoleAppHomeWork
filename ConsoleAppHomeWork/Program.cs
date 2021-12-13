using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user1 = new User("keren", "hailu", 1998, "keren@");
            //User user2 = new User("lior", "yosef", 1990, "lior@");
            //User user3 = new User("eden", "genet", 1988, "eden@");
            //User user4 = new User("tikva", "yosef", 1978, "tikva@");
            //List<User> users = new List<User>();
            //users.Add(user1);
            //users.Add(user2);
            //users.Add(user3);
            //users.Add(user4);
            //users.Sort();
            //Console.WriteLine(user1.Name);
            //Console.WriteLine(user1.Lname);
            //Console.WriteLine(user1.YearBorn);
            //Console.WriteLine(user1.Email);

            //שאלה 10
            Console.WriteLine("1 - add user , 2 -editing, 3- delete , 4-show one user ");
            switch (Console.ReadLine())
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    break;

            }

            //שאלה 6
            void getList(List<User> list)
            {
                FileStream fs = new FileStream(@"C:\Pupil\user.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        writer.WriteLine($"{list[i].Name} {list[i].Lname} {list[i].YearBorn} {list[i].Email}");
                    }

                }
            }

            getList(users);

            //שאלה 7
            void readFromFile()
            {
                FileStream fileStream = new FileStream(@"C:\Pupil\user.txt", FileMode.Open);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        reader.ReadLine();
                    }
                }
            }
            readFromFile();
            //שאלה 8
            void fileForEach(List<User> list, string name, string lname)
            {
                FileStream file = new FileStream($@"C:\Pupil\{name + lname}.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(file))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Name == name)
                        {
                            writer.WriteLine($"{list[i].Name} {list[i].Lname} {list[i].YearBorn} {list[i].Email}");
                            name = list[i].Name;
                        }
                    }
                }
            }
            for (int i = 0; i < users.Count; i++)
            {
                string name = users[i].Name;
                string lname = users[i].Lname;

                fileForEach(users, name, lname);
            }

            //לא טובה
            //שאלה 9
           void ReadfileForEach(List<User> list, string name, string lname)
            {
                FileStream fileStream = new FileStream($@"C:\Pupil\{name + lname}.txt", FileMode.Open);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    reader.ReadToEnd();
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            for (int i = 0; i < users.Count; i++)
            {
                string name = users[i].Name;
                string lname = users[i].Lname;

                ReadfileForEach(users, name, lname);
            }
        }
    }
}
