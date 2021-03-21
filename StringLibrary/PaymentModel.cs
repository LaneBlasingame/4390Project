using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibraries
{
    public class PaymentModel
    {
        public string PaymentType { get; set; }
        public string AccountName { get; set; }
        public double AccountNumber { get; set; }
        public int PaymentAmount { get; set; }
    }
}