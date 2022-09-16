using System;

namespace MDTwork1023
{
    class Program
    {

   
        static void Main(string[] args)
        {
            Console.WriteLine("Please select Menu: ");
            Console.WriteLine("1 ShopInfo");
            Console.WriteLine("2 OwnerInfo");
            Console.WriteLine("3 WorkerInfo");
            Console.WriteLine("4 Income&Outcom");
            Console.WriteLine("Other to Quit");
            int f = int.Parse(Console.ReadLine());

            if (f == 1)
            {
                Console.WriteLine("Register Values : 1,000,000 Bath");
                Console.WriteLine("Shop Brand : KFC Bang Khun Thian Seaside");
            }

            else if (f == 2)
            {
                Console.WriteLine("Founders Name : Asaa Surname : Radee Id: 11048-24597-744");
                Console.WriteLine("Founders Name : Saaa Surname : TT Id: 12450-24597-888");
                Console.WriteLine("Founders Name : Goo Surname : Tyyy Id: 11048-45966-659");
            }
            else if (f == 3)
            {
                Console.WriteLine("**********Salay Worker*********");
                Console.WriteLine("Name: JJ Surname: UU Age: 20 Salary: 15,000 bath");
                Console.WriteLine("Name: Wera Surname: Deerek Age: 26 Salary: 15,000 bath");
                Console.WriteLine("Name: Doo Surname: Rattee Age: 22 Salary: 15,000 bath");
                Console.WriteLine();
                Console.WriteLine("**********Delivery************");
                Console.WriteLine("Name: Ruu Surname: Saee Age: 20 Salary: 12,500 bath");
                Console.WriteLine("Name: Firy Surname: Isches Age: 19 Salary: 12,500 bath");
            }
        
    

        }

       /* public static FounderInfo[] InputFounder()
        {
            FounderInfo[] founders = new FounderInfo[3];

            for (int index = 0; index < founders.Length; index++)
            {
                Console.WriteLine("******** Input User Number: {0} ********", index + 1);

               Console.WriteLine()
               
            }
        }*/
}
