using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jQueryAjaxInASPNETCore.Models
{
    public class TransactionModel
    {
        public int TransactionId { get; set; }

        public string AccountNumber { get; set; }

        public string BeneficiaryName { get; set; }

        public string BankName { get; set; }

        public string SWIFTCode { get; set; }

        public int Amount { get; set; }
    }
}
