using System;

namespace W2L4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1.");
            string name1 = "Bartłomiej";
            string surname1 = "Poskart";
            int age1 = 23;
            char sex1 = 'm';
            long pesel1 = 97112505934;
            long nr1 = 210423123123;
            Console.WriteLine("Name: " + name1);
            Console.WriteLine("Surname: " + surname1);
            Console.WriteLine("Age: " + age1);
            Console.WriteLine("Sex: " + sex1);
            Console.WriteLine("PESEL: " + pesel1);
            Console.WriteLine("Employee number: " + nr1);



            Console.WriteLine("Exercise 2.");
            string a = "ś", b = "o", c = "c";
            Console.WriteLine(c + b + a);

            Console.WriteLine("Exercise 3.");
            double x, y, z;
            Console.Write("enter x: ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("enter y: ");
            y = Double.Parse(Console.ReadLine());
            
            z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            Console.WriteLine("Diagonal is equal: " + z);

            Console.WriteLine("Exercise 4.");
            int q;
            double w;
            string e;
            q = 10;
            w = 12.5;
            e = "Szkoła Dotneta";
            Console.WriteLine(q);
            Console.WriteLine(e);
            Console.WriteLine(w);

            Console.WriteLine("Exercise 5.");
            string name, surname, mail;
            int age;
            double weight, height;
            long pesel, nr, phoneNr;
            char sex = 'l';
            Console.WriteLine("Please enter values: name, surname, age, weight, height, mail, phone number, sex ('m' or 'k'), pesel and  employee number. ");
            Console.WriteLine("This program doesn't have error handling so please enter a valid data. Please enter double value using ',' ");
            /*Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Surname: ");
            surname = Console.ReadLine();

            Console.Write("Age: ");
            age = Int32.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            weight = Double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = Double.Parse(Console.ReadLine());

            Console.Write("Mail: ");
            mail = Console.ReadLine();

            Console.Write("Phone number: ");
            phoneNr = long.Parse(Console.ReadLine());
*/
            Console.Write("Sex: ");
            Sex gender;
            string str = Console.ReadLine();
            sex = Char.Parse(str);
            if (sex == 'k' )
            {
                Console.Write(Sex.female.ToString());
            } 
            else if(sex =='m')
            {
                Console.Write(Sex.male.ToString());
            }
            else
            {
                Console.WriteLine("Enter 'k' or 'm'.");
                sex = Console.ReadKey().KeyChar;
            }
            Console.WriteLine();


            Console.Write("PESEL: ");
            pesel = long.Parse(Console.ReadLine());

            Console.Write("Employee number: ");
            nr = long.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Thats all. Thanks for checking.");









        }
    }
}
