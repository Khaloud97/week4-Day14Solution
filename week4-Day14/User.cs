using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_Day14
{
    internal class User
    {
        public string  Name { get; set; }
        public int Age { get; set; }
        public double Money { get; set;}


        public User(string Name, int Age, double Money)
        {
            this.Name = Name;
            this.Age = Age;
            this.Money = Money;
        }


        // create Operater overLoding

        // (+) Operater overLoding
        public static double operator +(User a , User b)
        {
            double result= a.Money + b.Money;
            return result;
        }
        // (-) Operater overLoding
        public static double operator -(User a, User b)
        {
            double result = a.Money - b.Money;
            return result;
        }
        // (==) Operater overLoding
        public static bool operator ==(User a, User b)
        { 
           if(a.Money == b.Money)
            { 
                return true; 
            }
            return false;
        }
        // (!=) Operater overLoding
        public static bool operator !=(User a, User b)
        {
            if (a.Money == b.Money)
            {
                return false;
            }
            return true;
        }
    }
}
