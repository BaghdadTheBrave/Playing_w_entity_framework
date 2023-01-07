using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.Models
{
   public partial class Client
    {
        public string FirstLast
        {
            get => $"{NameClients} {SurnameClients}";
        }
    }
}
