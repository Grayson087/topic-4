using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp6
{
    internal class Program
    {
       public static void Main(string[] args)
        {

            // Grayson Lindsay
            string name, name1, last, login,product1 , product2;
            int age, Grade, ID, old,past, years;  
            double price1, average, Number1, Number2, Number3, number4, Price2 , price3;
            



            // part1

            Console.WriteLine("What is your name?");
                    name = Console.ReadLine();
                    Console.WriteLine("Hi " + name + " how old are you? ");
                    int.TryParse(Console.ReadLine(), out age);
                    Console.WriteLine("Ah your " + age + " years old. How much do you make a hour? " + name);
                    Double.TryParse(Console.ReadLine(), out price1);
                    Console.WriteLine("Ah " + price1.ToString("C") + " thats alot of money.");
            //Part 2

            Console.WriteLine(" imput the following");
            Console.WriteLine(" first name? ");
            name1 = Console.ReadLine();
            Console.WriteLine("last name? ");
            last = Console.ReadLine();
            Console.WriteLine(" login? ");
            login = Console.ReadLine();
            Console.WriteLine("Grade? ");
            int.TryParse(Console.ReadLine(), out Grade);
            Console.WriteLine(" Student ID?");  
            int.TryParse(Console.ReadLine(), out ID);
            Console.WriteLine(" Average ");
            Double.TryParse(Console.ReadLine(), out average);

            Console.WriteLine("Name = " + name1 + ", " + last);
            Console.WriteLine();
            Console.WriteLine("login = " + login);
            Console.WriteLine();
            Console.WriteLine("Grade =" + Grade);
            Console.WriteLine();
            Console.WriteLine("Student Id = " + ID);
            Console.WriteLine();
            Console.WriteLine("average = " + average);



            //part 3
            
            Console.WriteLine();
            Console.WriteLine("how old are you?");
            int.TryParse(Console.ReadLine(), out old); years = (old + 5);  past = old - 5;
            Console.WriteLine("wow your " + old + " Years Old, You are on the brink of death");
            Console.WriteLine();
            Console.WriteLine("in 5 years you will be " + years);
            Console.WriteLine();
            Console.WriteLine("5 years ago you were " + past);


            // part 4


            Console.WriteLine();
            Console.WriteLine("imput a nummber ");
            double.TryParse(Console.ReadLine(), out Number1);
            Console.WriteLine(" imput a second number");
            double.TryParse(Console.ReadLine(), out Number2);
            Console.WriteLine("imput a third number ");
            double.TryParse(Console.ReadLine(), out Number3); 
            number4 = (Number1 + Number2 + Number3) / 2;
            Console.WriteLine("if you add those numbers together and divide by 2 you get " + number4);


            //part5

            Console.WriteLine();
            Console.WriteLine(" tell me a product");
            product1 = Console.ReadLine();
            Console.WriteLine(" whats the price ");
            double.TryParse(Console.ReadLine(), out Price2);































           











        }
    }
}