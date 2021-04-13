using System;

namespace GetToKnowClassmatesArrayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Community Builder!");
            Console.WriteLine();

            string[] names = { "Sean", "Kalai", "Jean", "Justin", "Alice", "Jason", "Kristen" };
            string[] sHometown = { "Plymouth", "Troy", "Lascahobas", "Wyoming", "Detroit", "Courtright", "Orange Park" };
            string[] FavFoods = { "Pizza", "Dosa", "Fritay", "Baja Blast", "Sushi", "Mac & Cheese", "Macaroni and Cheese" };

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Which student would you like to learn about? Choose a number 0-6 ");
                int studentNum = int.Parse(Console.ReadLine());

                Console.WriteLine($"The student is: {names[studentNum]}");

                if (studentNum >= 7)
                {
                    Console.WriteLine("Enter a number between 0-6");
                    break;
                }

                string numS = names[studentNum];
                string favs = FavFoods[studentNum];
                Console.WriteLine("Press 1: Hometown");
                Console.WriteLine("Press 2: Food");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (numS == names[i])
                        {
                            string hometown = sHometown[i];
                            Console.WriteLine($"Hometown: {hometown}");
                        }
                    }
                }
                else if (choice == 2)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (favs == FavFoods[i])
                        {
                            string fav = FavFoods[i];
                            Console.WriteLine($"Hometown: {fav}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please eneter 1 or 2");
                }
                Console.WriteLine("Would you like to learn about anouther student? y/n");
                while (true)
                {
                    string input = Console.ReadLine().ToLower().Trim();
                    if (input == "y")
                    {
                        break;
                    }
                    else if (input == "n")
                    {
                        loop = false;
                        Console.WriteLine("Have a great day");
                        break;
                    }
                }

            }

        }
    }
 }

