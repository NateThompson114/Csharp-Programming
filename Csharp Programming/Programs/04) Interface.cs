using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    public interface ICanBeUsedAsAChair //declare interface
    {
        void SittingMessage();
    }

    class MilkCrate : ICanBeUsedAsAChair
    {
        public MilkCrate()
        {
            Console.WriteLine("I'm a milk crate.");
        }

        public void SittingMessage()
        {
            Console.WriteLine("I'm a crate being used as a chair.. hard work!");
        }
    }

    public class _04__Interface
    {
        public static void CanSitOn(ICanBeUsedAsAChair fakeChair)
        {
            fakeChair.SittingMessage();
        }

        public void ChairMessage()
        {
            MilkCrate milkCrate = new MilkCrate();
            CanSitOn(milkCrate);
        }
        
    }
}
