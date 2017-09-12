using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Model
{
    public class ContactProfileModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string NickName { get; set; }

        public string Organization { get; set; }

        public long Number { get; set; }
    }
}
