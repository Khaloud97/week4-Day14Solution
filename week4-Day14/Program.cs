using System;

namespace week4_Day14
{

    //create enum in my project

    enum Months
    {
        Jan =1,
        feb,
        march,
        aprile,
        may,
        june,
        july,
        agust,
        september,
        november,
        december


    }

    //enum for gender

    enum Gender
    {
        male,
        female
    }



    //enum by flage to use it as a bit 
    [Flags]
    enum prmission
    {
        None=0,
        Read=1,
        Write=2,
        Delete =4,
        Excute =8,
        level1 = Read | Write,
        level2 = Read | Write| Delete

    }


    internal class Program
    {
        static void Main(string[] args)

        {
            //-------------------------enum for Months------------------------------------------------------------
            Console.WriteLine("What Months you choose !");

            Months month =  Months.july;
            Console.WriteLine($"Month name:{month}");
            Console.WriteLine($"Months number: {(int)month}");


            //---------------------Enum Parsing--------------------------------------------------------------------
            Console.WriteLine("\n---------------------");
            Console.WriteLine("\nEnum with Parse !"); 
            
            string mont = "feb";
            Console.WriteLine((Enum.Parse(typeof(Months) , mont)));  //Parse
            Console.WriteLine((int)(Enum.Parse(typeof(Months), mont)));  //Parse

            //TryParse:
            Console.WriteLine("\n---------------------");
            Console.WriteLine("\nEnum with TryParse !");

            if (Enum.TryParse(mont,out Months mn))
            {
                Console.WriteLine(mn);
            }



            //-------------------------enum for gender------------------------------------------------------------
            Console.WriteLine("\n---------------------");
            Console.WriteLine("\nWhat gender you choose !");

            Gender gender = Gender.female;
            Console.WriteLine($"Gender type:{gender}");
            Console.WriteLine($"Gender number: {(int)gender}");


            //------------------------enum by flage--------------------------------------------------------------
            Console.WriteLine("\n---------------------");
            Console.WriteLine("\nWhat prmission you choose !");

            prmission myprmission = prmission.Write | prmission.Delete | prmission.Read;
            Console.WriteLine($"prmission type:{myprmission}");

            //------------------------enum by Has flage--------------------------------------------------------------
            Console.WriteLine("\n---------------------");
            Console.WriteLine("\nWhat prmission with Has flage you choose !");
            prmission Use = prmission.Write | prmission.Read;
            if(Use.HasFlag(prmission.level1))
            {
                Console.WriteLine($"prmission is read and write only:" +
                    $"{prmission.level1.ToString()}");
            }



            //------------------------Operater overLoding--------------------------------------------------------------
            Console.WriteLine("\n---------------------");
            Console.WriteLine("\nOperater overLoding Example:");

            User user1 = new User("Khaloud", 26, 2655);
            User user2 = new User("Sara", 28, 2005);

            Console.WriteLine(user1);
            Console.WriteLine(user2);

            Console.WriteLine(user1 + user2);
            Console.WriteLine(user1 - user2);
            Console.WriteLine(user1 == user2);
            Console.WriteLine(user1 != user2);
        }
    } 
}