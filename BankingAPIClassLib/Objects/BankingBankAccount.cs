using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAPI.Objects
{
    /// <summary>
    /// Banking Account Information
    /// </summary>
    public class BankingBankAccount
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Balance { get; set; }
        public DateTime CreatedDate { get; set; }
        public BankingUser Banking_User { get; set; }
        public List<BankingPayService> Banking_PayService { get; set; }
        public List<BankingTransfer> Banking_Transfer { get; set; }
        public List<BankingTransfer> Banking_Transfer1 { get; set; }
    }
}
