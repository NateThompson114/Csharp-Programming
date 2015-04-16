using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    public class _14__List_with_User_Control
    {
        public class Car
        {
            private int price;

            public Car(int carPrice)
            {
                price = carPrice;
            }

            public int GetPrice()
            {
                return price;
            }
        }

        public void carInfo()
        {
            var carCount = 0;

            do
            {
                Console.WriteLine("How many cars do you have?");

                try
                {
                    carCount = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("The amount you entered is invalid!");
                }
            } while (carCount == 0);

            var myCarList = new List<Car>(carCount);


            for (int iii = 0; iii < carCount; iii++)
            {
                var price = 0;
                do
                {
                    Console.WriteLine("Price of car #{0}", iii + 1);
                    try
                    {
                        price = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("The amount you entered is invalid!");
                    }


                } while (price == 0);

                myCarList.Add(new Car(price));
            }


            var markup = 0.00;
            do
            {
                Console.WriteLine("What percentage do you think the markup was\n (Their price to yours, usually 10% or more):");
                try
                {
                    markup = double.Parse(Console.ReadLine()) / 100;
                }
                catch (Exception)
                {
                    Console.WriteLine("The amount you entered is invalid!");
                }
            } while (markup == 0.00);

            var cpCount = 0;
            foreach (Car cp in myCarList)
            {
                var price = cp.GetPrice();
                Console.WriteLine("At a {0}% markup car {1}s base price was ${2} and you paid ${3},\n which is a difference of ${4}", markup * 100, cpCount += 1, price - (price * markup), price, price - (price - (price * markup)));
            }
        }
    }
}
