using System;

namespace EmployeeWageSwitchUC4
{
    class Program
    {
        public const int Fulltime = 1;
        public const int Parttime = 2;
        public const int Emprateperhr = 20;
        static void Main(string[] args)
        {
           

            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case Fulltime:
                    emphrs = 8;
                    break;
                case Parttime:
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
 
            empwage = emphrs * Emprateperhr;
            Console.WriteLine("Employee Wage : " + empwage);
            
        }
    }
}
