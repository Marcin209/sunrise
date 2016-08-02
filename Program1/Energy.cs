
using System;
using System.Threading;
using Sunrise.Energy.Computing;




//Projekt ENERGY
namespace Program1
{
    class Energy
    {
        static void Main(string[] args)
        {
            CalculateSunEnergy calculate = new CalculateSunEnergy();
            double latidue;   //szerokosć geograficzna
            int year = 2016;
            int month = 7;
            int day = 25;

            Console.WriteLine("Enter Latidue: ");
            latidue = Double.Parse(Console.ReadLine());
            calculate.setLatidue(latidue);

            Console.WriteLine("Enter hour :");
            int hour = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, month, day,hour,0,0);
            calculate.setData(date);

            Console.WriteLine("Direct radiation (KW/m2) : {0}", calculate.getWats());
            Console.ReadLine();

        }
    }
}
