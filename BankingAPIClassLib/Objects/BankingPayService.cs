using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAPI.Objects
{
    /// <summary>
    /// Banking Pay Service 
    /// </summary>
    public class BankingPayService
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public int BankAccountId { get; set; }
        public int Amount { get; set; }
        public bool Paid { get; set; }
        public DateTime PaidDate { get; set; }
        public BankingBankAccount Banking_BankAccount { get; set; }
        public BankingService Banking_Service { get; set; }
        public BankingUser Banking_User { get; set; }
    }
}
