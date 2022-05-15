using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatorKlubs
{
    public partial class Clients
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public partial class Workers
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public partial class Computers
    {
        public override string ToString()
        {
            return Convert.ToString(Id);
        }
    }
}
