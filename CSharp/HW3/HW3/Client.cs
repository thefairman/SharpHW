using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    enum ClientType { Usual, Vip, SuperVip }
    struct Client
    {
        public int id;
        public string firstName;
        public string middleName;
        public string lastName;
        public string address;
        public string phone;
        public int ordersDoneCount;
        public decimal ordersDoneSumm;
        public ClientType clientType;
    }
}
