using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatorKlubs
{
    class DataOut
    {
        public void workerOut()
        {
            IEnumerable<Workers> list_workers = from c in DatorKlubsEntities.GetContext().Workers orderby c.Name ascending, c.Name ascending select c;
            foreach (var item in list_workers)
            {
                Console.WriteLine("ID: " + Convert.ToString(item.Id) + "\t | Name: " + item.Name + "\t | Age: " + Convert.ToString(item.Age));
                Console.WriteLine();
            }
        }

        public void computerOut()
        {
            List<Computers> list_computers = new List<Computers>();
            list_computers = DatorKlubsEntities.GetContext().Computers.ToList();
            foreach (var item in list_computers)
            {
                Console.WriteLine("PC ID: " + Convert.ToString(item.Id) + "\t | PC Price: " + Convert.ToString(item.Price));
                Console.WriteLine();
            }
        }
        public void clientOut()
        {
            IEnumerable<Clients> client_list1 = from c in DatorKlubsEntities.GetContext().Clients orderby c.Name ascending, c.Name ascending select c;
            foreach (var item in client_list1)
            {
                Console.WriteLine("ID: " + Convert.ToString(item.Id) + "\t | Name: " + item.Name + "\t | E-mail: " + item.E_mail + "\t | Age: " + Convert.ToString(item.Age));
                Console.WriteLine();
            }
        }

        public void sessionlogOut()
        {
            List<Session_Log> list_sessionlog = new List<Session_Log>();
            list_sessionlog = DatorKlubsEntities.GetContext().Session_Log.ToList();
            foreach (var item in list_sessionlog)
            {
                Console.WriteLine("ID: " + Convert.ToString(item.Id) + " | Client: " + item.Clients + " | Worker: " + item.Workers + " | PC: " + item.Computers + " | Date and time: " + item.Date_time);
                Console.WriteLine();
            }
        }
    }
}
