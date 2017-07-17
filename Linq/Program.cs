using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    // Define a bank
    public class Bank
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            IEnumerable<string> fruitsStartsWithL = from fruit in fruits
                                                    where fruit.StartsWith("L")
                                                    select fruit;
            Console.WriteLine("List of words in the collection that start with the letter 'L'");
            Console.WriteLine("===============================================================");

            foreach (string fruit in fruitsStartsWithL)
            {
                Console.WriteLine($"{fruit}");
            }
            Console.WriteLine("================================================================");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");



            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96 };
            IEnumerable<int> newNumber = from numberlist in numbers
                                         where numberlist % 6 == 0 | numberlist % 4 == 0
                                         select numberlist;
            Console.WriteLine("List of numbers are multiples of 4 or 6");
            Console.WriteLine("==================================================================");
            foreach (int numberlist in newNumber)
            {
                Console.WriteLine($"{numberlist}");
            }
            Console.WriteLine("==================================================================");
            Console.ReadKey();

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
            };
            IEnumerable<string> nameDescending = from name in names
                                                 orderby name descending
                                                 select name;
            Console.WriteLine("List of student names alphabetically, in descending order (Z to A)");
            Console.WriteLine("===================================================================");

            foreach (string name in nameDescending)
            {
                Console.WriteLine($"{name}");

            }
            Console.WriteLine("====================================================================");
            Console.ReadKey();
            // Build a collection of these numbers sorted in ascending order
            List<int> numbersD = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> numAscending = from num in numbersD
                                            orderby num ascending
                                            select num;
            Console.WriteLine("List of number sorted in ascending order");
            Console.WriteLine("======================================================================");

            foreach (int num in numAscending)
            {
                Console.WriteLine($"{num}");

            }
            Console.ReadKey();
            // Output how many numbers are in this list
            List<int> numbersT = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            // IEnumerable<int>numTotal = from num in numbersT
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Total count of numbers in this list");
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"{numbersT.Count}");
            Console.ReadKey();


            // How much money have we made?
            List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
         };
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Total money we have made");
            Console.WriteLine("=======================================================================");

            Console.WriteLine($"{purchases.Sum()}");
            Console.ReadKey();

            // What is our most expensive product?
            List<double> prices = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Most expensive produce");
            Console.WriteLine("=======================================================================");

            Console.WriteLine($"{prices.Max()}");
            Console.ReadKey();

            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
        {
            66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
        };
            var tillPerfectSquare = "";
            foreach (int squareNum in wheresSquaredo)
            {
                double result = Math.Sqrt(squareNum);
                bool isSquare = result % 1 == 0;
                if (!isSquare)
                {
                    if (tillPerfectSquare != "")
                    {
                        tillPerfectSquare = tillPerfectSquare + ", " + squareNum;
                        // Console.WriteLine("Exit");

                    }
                    else
                    {
                        tillPerfectSquare = tillPerfectSquare + squareNum;

                    }

                }
                else
                {
                    break;
                }


            }

            Console.WriteLine("=======================================================================");
            Console.WriteLine("List till reached perfect square");
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"{tillPerfectSquare}");
            Console.ReadKey();

            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}

            };

            IEnumerable<Customer> millionare = from million in customers
                                               where million.Balance >= 1000000
                                               select million;

            Console.WriteLine("=======================================================================");
            Console.WriteLine("List of millionare customers");
            Console.WriteLine("=======================================================================");
            foreach (Customer million in millionare)
            {
                Console.WriteLine("Name: " + $"{million.Name}" + ", Balance: " + $"{million.Balance}" + ", Bank: " + $"{million.Bank}");
            }

            Console.ReadKey();


            /* 
                Given the same customer set, display how many millionaires per bank.
                Ref: https://code.msdn.microsoft.com/LINQ-to-DataSets-Grouping-c62703ea

                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
            */


            var millionBank = millionare.GroupBy(millionGroup => millionGroup.Bank);

            Console.WriteLine("=================================================================");

            foreach (var millionb in millionBank)
            {
                Console.WriteLine($"{millionb.Key}" + "  " + $"{millionb.Count()}");
            }
       
            Console.ReadKey();


            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            var millionaireReport = from cus in customers
                                    join bankM in banks on cus.Bank equals bankM.Symbol
                                    select new { CustomerName = cus.Name, BankName = bankM.Name };



            Console.WriteLine("=========================================================================");
            Console.WriteLine("Joining Two related collections");
            Console.WriteLine("=========================================================================");
            foreach (var customer in millionaireReport)
            {
                Console.WriteLine($"{customer.CustomerName} at {customer.BankName}");
            }
            Console.ReadKey();
 
        }

    }


}
