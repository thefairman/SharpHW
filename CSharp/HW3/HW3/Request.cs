using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    enum PayType { Cash, CreditCart, DigitWallet}
    struct Request
    {
        public int id;
        public Client client;
        public DateTime dateOdRequest;
        public RequestItem[] requests;
        public PayType payType;
        public decimal sumOfRequest
        {
            get {
                if (requests == null)
                    return 0m;
                decimal summ = 0;
                foreach (var item in requests)
                {
                    summ += item.count * item.product.price;
                }
                return summ; 
            }
        }

    }
}
