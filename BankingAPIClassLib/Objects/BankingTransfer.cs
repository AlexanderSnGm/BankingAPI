using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAPI.Objects
{
    /// <summary>
    /// Banking Transfer
    /// </summary>
    public class BankingTransfer
    {
        public int Id { get; set; }
        public int OriginAccount { get; set; }
        public int DestinationAccount { get; set; }
        public int UserId { get; set; }
        public int Balance { get; set; }
        public string Description { get; set; }
        public DateTime TransferDate { get; set; }
        public BankingBankAccount Banking_BankAccount { get; set; }
        public BankingBankAccount Banking_BankAccount1 { get; set; }
        public BankingUser Banking_User { get; set; }
    }
}
