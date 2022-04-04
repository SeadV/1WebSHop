using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojWebShop
{
    internal abstract class Person
    {
        public string _name = string.Empty;
        public string _surname = string.Empty;
        public string _username = string.Empty;
        public string _email = string.Empty;
        public string _password = string.Empty;

        public Address _address = new Address();

    }
}
