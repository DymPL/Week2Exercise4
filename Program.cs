using System;

namespace Week2Exercise4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Week2Exercise4");
            Console.WriteLine("");
            Exe2();
            Exe3();
            Exe4();
            Exe5();

        }

        public static void Exe1()
        {
            Console.WriteLine("Exercise 1");

            string firstname;
            string lastName;
            byte age;
            char gender;
            long pesel;
            long IDemployee;
        }

        public static void Exe2()
        {
            Console.WriteLine("Exercise 2");

            char firstChar = 'a';
            char secondChar = 'b';
            char threeChar = 'c';

            Console.WriteLine($" a b c --> {threeChar} {secondChar} {firstChar} \r\n");

        }

        public static void Exe3()
        {
            Console.WriteLine("Exercise 3");
            double width;
            double lenght;

            Console.WriteLine("Podaj szerokość: ");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość: ");
            double.TryParse(Console.ReadLine(), out lenght);

            double diagonal = Math.Sqrt(width * width + lenght * lenght);

            Console.WriteLine($"Szerokość: {width} \r\n Długość: {lenght} \r\n Przekątna: {diagonal} \r\n");

        }

        public static void Exe4()
        {
            Console.WriteLine("Exercise 4");

            int first = 1;
            string course = "Szkoła Dotneta";
            double second = 12.5;

            Console.WriteLine($"Pierwsza Liczba: {first}");
            Console.WriteLine($"Kurs: {course}");
            Console.WriteLine($"Druga Liczba: {second}");
            Console.WriteLine("");
        }

        public static void Exe5()
        {
            Console.WriteLine("Exercise 5");

            string name;
            string surname;
            int phone;
            string email;
            int height;
            double weight;

            Console.WriteLine("Podaj imię: ");
            name = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            surname = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu: ");
            Int32.TryParse(Console.ReadLine(), out phone);

            Console.WriteLine("Podaj adres email: ");
            email = Console.ReadLine();

            Console.WriteLine("Podaj wzrost: ");
            Int32.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("Podaj wagę: ");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dane użytkownika: \r\n Imię: {name} \r\n Nazwisko: {surname} \r\n " +
                $"Telefon: {phone} \r\n Email: {email} \r\n Wzrost: {height} \r\n Waga: {weight}");
        }
    }
}
