using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatorKlubs
{
    class clientMenu: DataOut
    {
        Clients client = new Clients();
        public void clientAdd()
        {
            Console.Clear();
            Console.Write("Enter name: ");
            client.Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter e-mail: ");
            client.E_mail = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter age: ");
            client.Age = Convert.ToInt32(Console.ReadLine());

            DatorKlubsEntities.GetContext().Clients.Add(client);
            DatorKlubsEntities.GetContext().SaveChanges();
            Console.WriteLine("Client added successfully!");
        }


        public void clientDelete()
        {
            Console.Clear();
            clientOut();
            Console.WriteLine();

            Console.Write("Enter client ID to delete: ");
            int clientAnwsInt = Convert.ToInt32(Console.ReadLine());
            var request_client = (from obj in DatorKlubsEntities.GetContext().Clients where clientAnwsInt == obj.Id select obj).Single();
            if (request_client != null)
            {
                Console.WriteLine("Are you sure? (Y/N)");
                string clientAnwsStr = Console.ReadLine();
                switch (clientAnwsStr)
                {
                    case "Y":
                        DatorKlubsEntities.GetContext().Clients.Remove(request_client);
                        DatorKlubsEntities.GetContext().SaveChanges();
                        Console.WriteLine("Client deleted successfully!");
                        Thread.Sleep(4000);
                        break;

                    case "N":
                        return;
                }
                
            }
            else
            {
                Console.WriteLine("Client with this number does not exist");
                Thread.Sleep(4000);
            }
        }
        public void clientEdit()
        {
            bool clientEditBool = true;
            while (clientEditBool == true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("   COMPUTER CLUB ADMINISTRATOR");
                Console.WriteLine("---------------------------------");
                Console.WriteLine();
                Console.WriteLine("ADD/DELETE CLIENT:");
                Console.WriteLine("--1. ADD CLIENT--");
                Console.WriteLine("--2. DELETE CLIENT--");
                Console.WriteLine("--3. BACK--");
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.Write("What do you want to do: ");
                int clientAnws = Convert.ToInt32(Console.ReadLine());

                switch (clientAnws)
                {
                    case 1:
                        clientAdd();
                        break;

                    case 2:
                        clientDelete();
                        break;

                    case 3:
                        clientEditBool = false;
                        break;
                }
            }
        }

        public void clientCheck()
        {
            bool clientCheckBool = true;
            while (clientCheckBool == true)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("   COMPUTER CLUB ADMINISTRATOR");
                Console.WriteLine("---------------------------------");
                Console.WriteLine();
                Console.WriteLine("CHECK CLIENTS:");
                clientOut();
                Console.WriteLine();
                Console.WriteLine("--1. BACK--");
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.Write("What do you want to do: ");
                int clientAnws = Convert.ToInt32(Console.ReadLine());

                switch (clientAnws)
                {
                    case 1:
                        clientCheckBool = false;
                        break;
                }
            }
        }
    }
}
