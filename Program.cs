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
                Console.WriteLine("Shop Brand : KFC Bang Khun Thian Seaside ");
                Console.WriteLine("Founder Name : A ");
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
