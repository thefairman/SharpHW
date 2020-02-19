using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    enum ArticleType { Simle, Digit, GiftCard }
    struct Article
    {
        public int id;
        public string name;
        public decimal price;
        public ArticleType articleType;
    }
}
