using System;

namespace Exercise_Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var adv = new Advertisement();
                Console.WriteLine($"{adv.Phrases()}{adv.Events()}{adv.Authors()} - {adv.Cities()}");
            }
        }
    }
    class Advertisement
    {
        public string Phrases() 
        {
            Random random = new Random();
            string result = "";
            int a =random.Next(0, 6);
            if (a == 0)
            {
                result = "Excellent product.";
            }
            else if (a == 1)
            {
                result = "Such a great product.";
            }
            else if (a == 2)
            {
                result = "I always use that product.";
            }
            else if (a == 3)
            {
                result = "Best product of its category.";
            }
            else if (a == 4)
            {
                result = "Exceptional product.";
            }
            else if (a == 5)
            {
                result = "I can’t live without this product.";
            }

            return result;
        }
        public string Events()
        {
            Random random = new Random();
            string result = "";
            int a = random.Next(0, 6);
            if (a == 0)
            {
                result = "Now I feel good.";
            }
            else if (a == 1)
            {
                result = "I have succeeded with this product.";
            }
            else if (a == 2)
            {
                result = "Makes miracles. I am happy of the results!";
            }
            else if (a == 3)
            {
                result = "I cannot believe but now I feel awesome.";
            }
            else if (a == 4)
            {
                result = "Try it yourself, I am very satisfied.";
            }
            else if (a == 5)
            {
                result = "I feel great!";
            }

            return result;
        }
        public string Authors()
        {
            Random random = new Random();
            string result = "";
            int a = random.Next(0, 8);
            if (a == 0)
            {
                result = "Diana";
            }
            else if (a == 1)
            {
                result = "Petya";
            }
            else if (a == 2)
            {
                result = "Stella";
            }
            else if (a == 3)
            {
                result = "Elena";
            }
            else if (a == 4)
            {
                result = "Katya";
            }
            else if (a == 5)
            {
                result = "Iva";
            }
            else if (a == 6)
            {
                result = "Annie";
            }
            else if (a == 7)
            {
                result = "Eva";
            }

            return result;
        }
        public string Cities()
        {
            Random random = new Random();
            string result = "";
            int a = random.Next(0, 5);
            if (a == 0)
            {
                result = "Burgas";
            }
            else if (a == 1)
            {
                result = "Sofia";
            }
            else if (a == 2)
            {
                result = "Plovdiv";
            }
            else if (a == 3)
            {
                result = "Varna";
            }
            else if (a == 4)
            {
                result = "Ruse";
            }

            return result;
        }
    }
}
