using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAPI.Objects
{
    public class BankingCidInformation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<BankingBankAccount> Banking_BankAccount { get; set; }
        public List<BankingPayService> Banking_PayService { get; set; }
        public List<BankingTransfer> Banking_Transfer { get; set; }
    }
}
