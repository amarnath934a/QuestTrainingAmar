using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class CreditCard
    {
        public string CardHolderName;
        public string CardNumber;
        public int Expiry;
        public int Cvv;
        public override string ToString()
        {
            return $" name: {CardHolderName} ,Number : {CardNumber} , Expiry: {Expiry}, cvv: {Cvv}";
        }
    }
}
