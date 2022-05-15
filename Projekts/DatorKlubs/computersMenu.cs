using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatorKlubs
{
    class computersMenu: DataOut
    {
        List<Computers> list_computers = new List<Computers>();

        public void computerCheck()
        {
            list_computers = DatorKlubsEntities.GetContext().Computers.ToList();
            bool computerCheckBool = true;
            while (computerCheckBool == true)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("   COMPUTER CLUB ADMINISTRATOR");
                Console.WriteLine("---------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("COMPUTERS COUNT: " + list_computers.Count());
                computerOut();
                Console.WriteLine();
                Console.WriteLine("--1. BACK--");
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.Write("What do you want to do: ");
                int clientAnws = Convert.ToInt32(Console.ReadLine());

                switch (clientAnws)
                {
                    case 1:
                        computerCheckBool = false;
                        break;
                }
            }
        }
    }
}
